
/*  ----------------------------------------------------------------
http://www.prometec.net/nrf2401
Prog_79_1_Emisor

Programa para recibir strings mediante radios NRF2401
--------------------------------------------------------------------
*/

#include "LowPower.h"
#include <nRF24L01.h>
#include <RF24.h>
#include <RF24_config.h>
#include <SPI.h>
#include "LowPower.h"

#define MAX_ULTRASONIDOS   4
#define MAX_DISTANCIAS     20
#define MAX_MICROS_ESPERA  4000 //12m recorridos por el sonido

#define DIR_BROADCAST	   0x000000000BLL
#define DIR_BALIZA1		   0x00000000B1LL	

#define ENVIAR_PULSO       5
#define ALIMENTACION       4 /* alimentación ON -> LOW*/
#define LED                3

#define ENCENDER           LOW
#define APAGAR             HIGH

#define LONGITUD_PAQUETE  sizeof(sPaquete)

#define SET_MODE			1
#define SET_OPERATION		2

#define MODE_HIBERNATE		1
#define MODE_SUSPEND		2
#define MODE_ALERT			3
#define MODE_ACTIVE			4

#define OP_READ_INIT		1
#define OP_READ_DISTANCE	2
#define OP_READ_FIN			3
#define OP_SET_MODE			4


#define CONTADOR_PAQUETE	1
#define CONTADOR_ALERT		9
#define CONTADOR_SUSPENSION	8

#define ESPERA_PAQUETE		200
#define TIEMPO_INACTIVIDAD_PARA_SUSPENSION	4 //número de segundos después de haber activado el modo alert
#define TIEMPO_INACTIVIDAD_PARA_ALERT		4 //segundos

#define OP_INICIAR			1
#define OP_CONSULTAR		2

struct sPaquete
{
	byte operacion;
	union 
	{
		byte modo;
		unsigned long direccion;
		unsigned long num_lecturas;
	};
};

sPaquete paquete;
int NumeroLecturas = 0;
int NumeroLecturasActual = 0;
float medidas[MAX_DISTANCIAS];
int MODO = MODE_ALERT;

RF24 radio(8, 7);
const uint64_t broadcast = DIR_BROADCAST;
int lectura_pulso[MAX_ULTRASONIDOS] = { 2, 6, 9, 10 };

void setup(void)
{
	Serial.begin(9600);
	radio.begin();
	radio.setPALevel(RF24_PA_MIN);
	radio.setAutoAck(DIR_BROADCAST, false);
	radio.setPayloadSize(LONGITUD_PAQUETE);

	radio.powerDown();

	pinMode(ENVIAR_PULSO, OUTPUT);
	for (int i = 0; i<MAX_ULTRASONIDOS; i++)
		pinMode(lectura_pulso[i], INPUT);
	pinMode(ALIMENTACION, OUTPUT);

	//digitalWrite(ALIMENTACION, APAGAR); //Apagamos los sensores de ultrasonidos
}

void loop(void)
{
	Serial.begin(9600);
	Serial.println("1");
	delay(500);

	switch (MODO)
	{
		case MODE_ALERT:
		{
			digitalWrite(ALIMENTACION, APAGAR);

			if (MODO == MODE_SUSPEND)
				LowPower.powerDown(SLEEP_8S, ADC_OFF, BOD_OFF);
			else if (MODO == MODE_ALERT)
			{
				//Si en TIEMPO_INACTIVIDAD_ALERT seg no recibimos paquetes pasamos a modo suspensión
				if (!Espera(TIEMPO_INACTIVIDAD_PARA_SUSPENSION, CONTADOR_SUSPENSION, OP_CONSULTAR))
					MODO = MODE_SUSPEND;
				LowPower.powerDown(SLEEP_2S, ADC_OFF, BOD_OFF);
			}
			Serial.println("0");
			delay(500);

			radio.powerUp();

			Serial.println("0");
			delay(500);

			radio.openReadingPipe(1, broadcast);
			radio.startListening();

			Serial.println("0");
			delay(500);
			Espera(ESPERA_PAQUETE, CONTADOR_PAQUETE, OP_INICIAR);
			while (Espera(ESPERA_PAQUETE, CONTADOR_PAQUETE, OP_INICIAR))
			{
				if (radio.available())
				{
					Espera(TIEMPO_INACTIVIDAD_PARA_SUSPENSION, CONTADOR_SUSPENSION, OP_INICIAR);
					radio.read(&paquete, LONGITUD_PAQUETE);
					if (ComprobarCambioModo(&paquete))
						break;
				}
			}
			Serial.println("0");
			delay(500);
			radio.stopListening();
			break;
		}
		case MODE_ACTIVE:
		{
			//Si pasó el tiempo indicado sin paquetes, pasamos al modo alerta
			if (!Espera(TIEMPO_INACTIVIDAD_PARA_ALERT, CONTADOR_ALERT, OP_CONSULTAR))
			{
				Espera(TIEMPO_INACTIVIDAD_PARA_SUSPENSION, CONTADOR_SUSPENSION, OP_INICIAR);
				MODO = MODE_ALERT;
				radio.stopListening();
				radio.powerDown();
				break;
			}

			if (radio.available())
			{
				Espera(TIEMPO_INACTIVIDAD_PARA_ALERT, CONTADOR_ALERT, OP_INICIAR);
				radio.read(&paquete, LONGITUD_PAQUETE);
				if (ComprobarCambioModo(&paquete))
				{
					NumeroLecturasActual = 0;
					break;
				}
				else
				{
					switch (paquete.operacion)
					{
						case OP_READ_INIT:
						{
							NumeroLecturas = paquete.num_lecturas;
							NumeroLecturasActual = 0;
						}
						case OP_READ_DISTANCE:
						{
							digitalWrite(ALIMENTACION, ENCENDER);
							delayMicroseconds(10);
							digitalWrite(ENVIAR_PULSO, LOW); /* Por cuestión de estabilización del sensor*/
							delayMicroseconds(5);
							digitalWrite(ENVIAR_PULSO, HIGH); /* envío del pulso ultrasónico*/
							delayMicroseconds(10);

							//Esperamos hasta recuperar un pulso alto en alguna entrada
							byte baliza = 0;
							byte lectura = LOW;
							unsigned long tiempo = 0;
							unsigned long tiempo_ini = micros();

							Espera(MAX_MICROS_ESPERA, CONTADOR_PAQUETE, OP_INICIAR);
							while (!Espera(MAX_MICROS_ESPERA, CONTADOR_PAQUETE, OP_CONSULTAR))
							{
								for (int i = 0; i < MAX_ULTRASONIDOS; i++)
								{
									if (digitalRead(lectura_pulso[baliza]) == HIGH)
									{
										tiempo = micros();
										break;
									}
								}
							}
							medidas[NumeroLecturasActual++] = tiempo;
							break;
						}
						case OP_READ_FIN:
						{
							//Transmitimos la media de las lecturas
						}
					}
				}
			}
		}
	}
}

bool Espera(unsigned long ms, int contador, int op)
{
#define MAX_US				4294967295

	static unsigned long us_ini[10] = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
	unsigned long us_actual[10];

	us_actual[contador] = micros();

	if (op == OP_INICIAR)
		us_ini[contador] = micros();
	else
	{
		if (us_actual[contador] < us_ini[contador])
		{
			us_actual[contador] = MAX_US - us_ini[contador] + us_actual[contador];
			us_ini[contador] = 1;
		}

		if (us_actual[contador] - us_ini[contador] >= ms * 1000)
		{
			us_ini[contador] = 0;
			return false;
		}
		else
			return true;
	}
}

bool ComprobarCambioModo(struct sPaquete *paquete)
{
	if (paquete->operacion == OP_SET_MODE)
	{
		switch (paquete->modo)
		{
		case MODE_HIBERNATE: // Se reanuda cada 8s para controlar el RTC (En modo hibernate se entra por programación RTC)
		{
			MODO = MODE_HIBERNATE;
			break;
		}
		case MODE_SUSPEND: // Se reanuda cada 8s para comprobar la recepción de paquetes
		{
			MODO = MODE_SUSPEND;
			break;
		}
		case MODE_ALERT: //Se reanuda cada 2 segundos para comprobar la recepción de paquetes
		{
			MODO = MODE_ALERT;
			break;
		}
		case MODE_ACTIVE: //La radio está constantemente activa
		{
			if (MODO != MODE_ACTIVE)
			{
				MODO = MODE_ACTIVE;
				Espera(TIEMPO_INACTIVIDAD_PARA_ALERT, CONTADOR_ALERT, OP_INICIAR);
				radio.openReadingPipe(1, broadcast);
				radio.startListening();
				Serial.println("MODE_ACTIVE");
			}
			break;
		}
		}
		return true;
	}
	return false;
}

