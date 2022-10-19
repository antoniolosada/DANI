// Controlling a servo position using a potentiometer (variable resistor) 
// by Michal Rinott <http://people.interaction-ivrea.it/m.rinott> 

#include <Arduino.h>

#ifndef SAPPO_H
	//#include <Servo.h>
	#include <ServoTimer2.h>
	#define Servo ServoTimer2

	#include <RF24.h>
	#include <RF24_config.h>
	#include <VirtualWire.h>
	#include "pines.h"

	#include "list.h"
	#include "node_cpp.h"
	#ifndef CODE_LIST
		#include "list.cpp"
		#include "node_cpp.cpp"
	#endif

	#include "SAPPO.h"
#endif
//#include <TimerOne.h>

#define DEBUG  0
#define VALOR_MEDIO		100
#define VALOR_COLISION_US	80

#define MS_CONTROL_POS      50 // Se controla el reposicionamiento en parada de los servos 20 veces por segundo


//#define CONTADOR_VELOCIDAD	19
//#define PIN_ALIMENTACION_CUERPO    21
//#define PIN_ALIMENTACION_BASE      20

#define VALOR_DISTANCIA_CM_MIN		4
#define VALOR_DISTANCIA_CM_MAX		100
#define VALOR_DISTANCIA_MIN			185
#define VALOR_DISTANCIA_MAX			265
#define VALOR_OBJETO_NO_DETECTADO	-1

#define FIN_SECUENCIA  0
#define FIN_MOVIMIENTO 0
#define SECUENCIA_EN_PROCESO  1

#define MAX_SEC 100

#define RUN 1
#define STOP 2
#define PAUSE 3

#define LECTURA_FIN  1
#define SIN_ASIGNAR  -1
#define MOV_CONTROL  -2
#define TIEMPO_ITERACION_MS  5

#define DISTANCIA_DERECHA	21
#define DISTANCIA_IZQUIERDA	20
#define DISTANCIA_CENTRO	19
#define DISTANCIA_TRASERA	18

#define SENSOR_DISTANCIA_DERECHA	3
#define SENSOR_DISTANCIA_CENTRO		2
#define SENSOR_DISTANCIA_IZQUIERDA	1
#define SENSOR_DISTANCIA_TRASERA	0

#define PERIODO_MEDIDA_DISTANCIA_MS 1000

#define MAX_LON_CADENA 400

#define MAX_SERVOS_POS 25
#define REC_MEDIDAS  1

//PINes de los sensores de distancia
byte DistanciaEcho[4] = { PIN_ECHO_DIST_DELANTE_1,
							PIN_ECHO_DIST_DELANTE_2,
							PIN_ECHO_DIST_DELANTE_3,
							PIN_ECHO_DIST_ATRAS_1 };

byte DistanciaTriger[4] = { PIN_TRIGGER_DIST_DELANTE_1,
							PIN_TRIGGER_DIST_DELANTE_2,
							PIN_TRIGGER_DIST_DELANTE_3,
							PIN_TRIGGER_DIST_ATRAS_1 };
long DistanciaUs[4] = { 0, 0, 0, 0 };
int DistanciaCm[4] = { 0, 0, 0, 0 };

String Debug = "";
Servo aServo[MAX_SERVOS_POS];
struct sPosServos 
{
  int iValor;
  int iUnidad;
  int iIteraciones;
  int iMaxIteraciones;
  int iValorInicial;
  int iValorFinal;
  byte pin;
  bool Conectado;
  unsigned long ms_desconexion;
  byte iValoIniTemporizado;
  byte iValorFinTemporizado;
  unsigned int ms_tiempo_mov;
  long ms_inicial = 0;
  long ms_final = 0;
  bool MovTemporizadoActivo = false;
} aPosServos[MAX_SERVOS_POS];

int iPosCad = 0;
char Cadena[MAX_LON_CADENA];

struct Movimiento 
{
  byte BNumMov;
  int iTiempo;
  int pos[MAX_SERVOS_POS];
};

Movimiento Secuencia[10];
long cont_loop = 0;

int iPosSec = 0;
int iEstado = STOP;
int iNumSecActiva = SIN_ASIGNAR;
int iNumMovActivo = SIN_ASIGNAR;
int iFinSec = 0;
long ContadorMarcas = 0;
bool RecuperarPosicion = false;
long ContadorMs;

static long timeControlPos = millis();

extern bool ControlPosicionActivo;
extern bool ControlLimitesOffActivo;
extern bool ControlLimitesActivo;
extern int algoKalman;

void InicializarRadio();
void InicializarSAPPO_us();
void CargarDatosBalizas();
bool RecuperarMedidasBalizas(int algoritmo, bool salida);

void setup() 
{ 
  int i;
  
  Debug = "I";
  iPosCad = 0;

  ControlPosicionActivo = false;
  ControlLimitesOffActivo = false;
  ControlLimitesActivo = true;

  ContadorMs = millis();

  for (i = 0; i < 4; i++)
  {
	  pinMode(DistanciaEcho[i], INPUT);
	  pinMode(DistanciaTriger[i], OUTPUT);
  }

  //Timer1.initialize(250000);         // Dispara cada 250 ms
  //Timer1.attachInterrupt(ControlLimites); // Activa la interrupcion y la asocia a ISR_Blink
  pinMode(PIN_CONTADOR_VELOCIDAD, INPUT);
  attachInterrupt(digitalPinToInterrupt(PIN_CONTADOR_VELOCIDAD), ContadorVelocidad, CHANGE); //INT4 -> pin 2
  attachInterrupt(2, DistanciaD, FALLING); //INT4 -> pin 21 D
  attachInterrupt(3, DistanciaC, FALLING); //INT4 -> pin 20 C
  attachInterrupt(4, DistanciaI, FALLING); //INT4 -> pin 19 I
  attachInterrupt(5, DistanciaT, FALLING); //INT4 -> pin 18 T

  pinMode(PIN_ALIMENTACION_BASE, OUTPUT);
  pinMode(PIN_ALIMENTACION_CUERPO, OUTPUT);
  pinMode(PIN_ALIMENTACION_CABEZA, OUTPUT);

  digitalWrite(PIN_ALIMENTACION_CUERPO, HIGH);
  digitalWrite(PIN_ALIMENTACION_BASE, HIGH);
  digitalWrite(PIN_ALIMENTACION_CABEZA, HIGH);

  pinMode(PIN_SENSOR_LINEA_L, INPUT);
  pinMode(PIN_SENSOR_LINEA_C, INPUT);
  pinMode(PIN_SENSOR_LINEA_R, INPUT);

  Serial.begin(115200);

  int pinServo = 0;
  //Establecer posici�n inicial de los servos
  for (i = 0; i < MAX_SERVOS_POS; i++)
  {
    aPosServos[i].MovTemporizadoActivo = false;
	pinServo = pin(i);
    if (pinServo > 0)
    {
      aServo[i].attach(pinServo);
      aPosServos[i].iIteraciones = 0;
      aPosServos[i].pin = pinServo;
      aPosServos[i].Conectado = true;
      aPosServos[i].ms_desconexion = millis();
    }
    else
    {
        aPosServos[i].pin = 0;
        aPosServos[i].Conectado = false;
    }
    aPosServos[i].iValor = 0;
    aPosServos[i].ms_tiempo_mov = 0; //Marca de movimiento programado del servo desactivo
  }
  PosicionInicial();

  //SAPPO Inicializacion
  InicializarRadio();
  InicializarSAPPO_us();
  CargarDatosBalizas();

  delay(2000);

  
//  Serial.println("-----------------------------------------");
//  Serial.print("RAM libre: ");
//  Serial.print(freeRam());
//  Serial.print(";");
} 
 
void loop() 
{ 
	//return;
	//PruebaMovimientoCabeza();
	cont_loop++;

  if (LeerCadena(&iPosCad, Cadena) == LECTURA_FIN)
  {
    ProcesarCadena(Cadena);
    Cadena[0] = 0;
  }
  //MovimientoTemporizado();

  long Tiempo = millis() - ContadorMs;
  if ((Tiempo < 0) || (Tiempo > PERIODO_MEDIDA_DISTANCIA_MS))
  {
	  ComprobarControlColision();
  }

  if (ControlLimitesOffActivo) ControlLimitesArticulacionesApagado(); //Apagado zona de alimentaci�n
  if (ControlLimitesActivo) ControlLimitesArticulaciones(); //Parada servo

  //20 veces por segundo se lanza el control de posición de las articulaciones
  if (millis() - timeControlPos > MS_CONTROL_POS)
  {
      if (ControlPosicionActivo) ControlPosicion();
      timeControlPos = millis();

      ControlDesconexionServos(); //Desconecta los servos para evitar movimientos y vibraciones
      ControlPosicionamientoServosRot(); //Para el servo rotacional cuando llega a la posici�n indicada
  }
  ControlMovimientoTemporizado(); //Movimiento suave de servos normales

  bool medidas = false;

  if ((cont_loop % REC_MEDIDAS) == 0 )
  {
  	if (RecuperarPosicion)
  		medidas = RecuperarMedidasBalizas(algoKalman, false);
  }

} 

void ControlDesconexionServos()
{
	int i = 0;
	int p;

	  for (i = 0; i < MAX_SERVOS_POS; i++)
	  {
		p = pin(i);
	    if (p > 0)
	    {
		  if (aPosServos[i].Conectado)
			  if (aPosServos[i].ms_desconexion < millis())
			  {
				  aServo[i].detach();
				  aPosServos[i].Conectado = false;
			  }
	    }
	  }
}

void MovimientoTemporizado()
{
    switch (iEstado)
    {
        case RUN:
        {
            if (iPosSec > 0) //Solo entramos si hay secuencias
            {
                if (EjecutarSecuencia() == FIN_SECUENCIA)
                {
                    if (CargarSecuencia() == FIN_MOVIMIENTO)
                    {
                        Serial.println(">STOP_FIN");
                        iEstado = STOP;  //Finalizamos el último movimiento de la secuencia
                        iNumSecActiva = SIN_ASIGNAR;
                    }
                }
            }
            break;
        }
    }
    delay(TIEMPO_ITERACION_MS);                           // waits for the servo to get there 
}

void MedirDistanciaSensor3()
{
	ContadorMs = millis();

	unsigned int tiempo, distancia;

	digitalWrite(DistanciaTriger[3], LOW);
	delayMicroseconds(2);
	digitalWrite(DistanciaTriger[3], HIGH);
	delayMicroseconds(10);
	digitalWrite(DistanciaTriger[3], LOW);
	// Calcula la distancia midiendo el tiempo del estado alto del pin ECHO
	tiempo = pulseIn(DistanciaEcho[3], HIGH);
	// La velocidad del sonido es de 340m/s o 29 microsegundos por centimetro
	distancia = tiempo / 58;
	//manda la distancia al monitor serie
	DistanciaCm[3] = distancia;
}

void ComprobarControlColision()
{
	int i;
	for (i = 0; i < 4; i++)
		digitalWrite(DistanciaTriger[i], LOW);
	delay(2);
	for (i = 0; i < 4; i++)
	{
		digitalWrite(DistanciaTriger[i], HIGH);
		DistanciaUs[i] = micros();
        if (DistanciaUs[i] < VALOR_COLISION_US)
        {
            //Parar los motores
            ApagadoMotorProgresivo();
            digitalWrite(PIN_ALIMENTACION_BASE, HIGH); //Apagar base
        }
	}
	delay(10);
	for (i = 0; i < 4; i++)
	{
		digitalWrite(DistanciaTriger[i], LOW);
	}

}

void ContadorVelocidad()
{
	ContadorMarcas++;
}

void DistanciaD()
{
	MedirDistancia(SENSOR_DISTANCIA_DERECHA);
}
void DistanciaC()
{
	MedirDistancia(SENSOR_DISTANCIA_CENTRO);
}
void DistanciaI()
{
	MedirDistancia(SENSOR_DISTANCIA_IZQUIERDA);
}
void DistanciaT()
{
	MedirDistancia(SENSOR_DISTANCIA_TRASERA);
}
void MedirDistancia(byte sensord)
{
	if (DistanciaUs[sensord] > 0)
	{
		//double cm = (1.0 * micros() - DistanciaUs[sensord]) * 10 / 292 / 2;
		double cm = (1.0 * micros() - DistanciaUs[sensord]) /58;

		int v = DistanciaCm[sensord];

		if ((cm > VALOR_DISTANCIA_MAX) || (cm < VALOR_DISTANCIA_MIN))
			cm = VALOR_OBJETO_NO_DETECTADO;
		else
		{
			cm = 1.0 * (VALOR_DISTANCIA_CM_MAX - VALOR_DISTANCIA_CM_MIN) / (VALOR_DISTANCIA_MAX - VALOR_DISTANCIA_MIN) * (cm - VALOR_DISTANCIA_MIN) + VALOR_DISTANCIA_CM_MIN;
		}
		DistanciaCm[sensord] = cm;
		DistanciaUs[sensord] = 0;
	}
}

int CargarSecuencia()
{
  int i;
  int iNum;

    if (iNumMovActivo == SIN_ASIGNAR)
      return FIN_MOVIMIENTO;
    else
    {
      if (iNumSecActiva == SIN_ASIGNAR)
      {
        //Recuperamos la primera posición del movimiento
        for (i=0; i<iPosSec; i++)
        {
          if (Secuencia[iNum].BNumMov == iNumMovActivo)
          {
            iNumSecActiva = iNum = i;
            break;
          }
        }
      }
      else
      {
        //Comprobamos que la secuencia sigue perteneciendo al mismo movimiento y no el la última
        iNumSecActiva++;
        if ((Secuencia[iNumSecActiva].BNumMov != iNumMovActivo) || (iNumSecActiva >= iPosSec))
        {
          Serial.print(">FIN_MOV-");
          Serial.println(iNumMovActivo);
          iNumMovActivo = SIN_ASIGNAR;
          iNumSecActiva = SIN_ASIGNAR;
          return FIN_MOVIMIENTO;
        }
      }
      Serial.print(">CARGA_SEC-");
      Serial.println(iNumSecActiva);    
      for (i=0; i<22; i++)
      {
        aPosServos[i].iValorInicial = aPosServos[i].iValor;
        aPosServos[i].iValorFinal = Secuencia[iNumSecActiva].pos[i];
        aPosServos[i].iIteraciones = 1;
        //Si el valor del servo no está asignado o no tiene que moverse se colocan a 0 las iteraciones
        if ((aPosServos[i].iValorFinal == SIN_ASIGNAR))
          aPosServos[i].iMaxIteraciones = 0;
        else
          aPosServos[i].iMaxIteraciones = Secuencia[iNumSecActiva].iTiempo/TIEMPO_ITERACION_MS+1;
      }
    }
    return SECUENCIA_EN_PROCESO;
}

int EjecutarSecuencia()
{
  int i;
  int iPos;
  int iCambio = FIN_SECUENCIA;
  //Ejecutamos la iteracción de la secuencia actual
  
  if (iNumSecActiva != SIN_ASIGNAR)
  {
      for (i=0; i<22; i++)
      {
        if (aPosServos[i].iIteraciones <= aPosServos[i].iMaxIteraciones)
        {    
          LOG2int("servo->", i+2);
          LOG2int("i->", aPosServos[i].iIteraciones);
          iPos = aPosServos[i].iValorInicial + (aPosServos[i].iValorFinal-aPosServos[i].iValorInicial)*aPosServos[i].iIteraciones/aPosServos[i].iMaxIteraciones;
          LOG2int("vi->", aPosServos[i].iValorInicial);
          LOG2int("vf->", aPosServos[i].iValorFinal);
          LOG2int("p->", iPos);
          aPosServos[i].iIteraciones++;
          AsignarServo(i+2, iPos, aPosServos[i].iUnidad);  
          iCambio = SECUENCIA_EN_PROCESO;
        }
      }
  }   
  return iCambio;
}


void LOG2int(char *c1, int i2)
{
  if (DEBUG)
  {
    Serial.print(c1);
    Serial.println(i2);
  }
}
void LOG2(char *c1, char *c2)
{
  if (DEBUG)
  {
    Serial.print(c1);
    Serial.println(c2);
  }
}
void LOG3(char *c1, char *c2, char *c3)
{
  if (DEBUG)
  {
    Serial.print(c1);
    Serial.print(c2);
    Serial.println(c3);
  }
}

void LOG_DEBUG(char *c1, long l1, long l2, float l3, float l4)
{
    Serial.print("DBG: ");
    Serial.print(c1);
    Serial.print(", ");
    Serial.print(l1);
    Serial.print(", ");
    Serial.print(l2);
    Serial.print(", ");
    Serial.print(l3);
    Serial.print(", ");
    Serial.print(l4);
    Serial.println(";");
}

void ControlLimites()
{

}

void PruebaMovimientoCabeza()
{
	for (int i = 0; i < 20; i++)
	{
		int j;
		for (j = 40; j < 100; j++)
		{
			AsignarServo(15, j, 0);
			delay(20);
		}
		delay(2000);
		for (j = 90; j > 40; j--)
		{
			AsignarServo(15, j, 0);
			delay(20);
		}
	}
	return;
}

void DebugInt(int valor, bool concatenar)
{
    char tmp[10];

    itoa(valor, tmp, 10);

    if (concatenar)
        Debug = Debug + tmp;
    else
        Debug = tmp;
}

void DebugChar(char valor, bool concatenar)
{
    char tmp[2];

    tmp[1] = 0;
    tmp[0] = valor;

    if (concatenar)
        Debug = Debug + tmp;
    else
        Debug = tmp;
}

void DebugCadena(String valor, bool concatenar)
{
    if (concatenar)
        Debug = Debug + valor;
    else
        Debug = valor;
}

int freeRam() {
  extern int __heap_start, *__brkval;
  int v;
  return (int)&v - (__brkval == 0 ? (int)&__heap_start : (int)__brkval);
}

