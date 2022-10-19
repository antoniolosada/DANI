#include <Arduino.h>
#include "pines.h"
#include "node_cpp.h"
#ifndef CODE_LIST
	#include "list.cpp"
	#include "node_cpp.cpp"
#endif

#include <MeanFilterLib.h>
#include "FiltroKalman.h"
#include "Kalman.h"
#include <RF24.h>
#include <RF24_config.h>
#include <VirtualWire.h>
#include "list.h"
#include "SAPPO.h"

boolean RecuperarMedidaMultiple(int emisor, int LOG);
void EnviarPulsoUltrasonidos(int emisor);
void EnviarMensaje433Mhz(int lectura);
bool Espera(unsigned long ms, int contador, int op);
extern void LOG_DEBUG(char *c1, long l1, long l2, float l3, float l4);

/* SAPPO Configuración *********************************************************************************/

RF24 radio(PIN_NRF24_CE, PIN_NRF24_CSN);
const uint64_t pipe1 = 0x00000000E1LL;    // Usamos este canal
const uint64_t pipe2 = 0x00000000E2LL;    // Usamos este canal
const uint64_t broadcast = 0xE8E8F0F0E1LL; // Usamos este canal
char direccion[3][6] = {"0Nodo", "1Nodo", "2Nodo"};

List<sBaliza> ListaBalizas;
List<sMedidas> ListaMedidasBalizas;
sProcesoMedida ProcesoMedida;
byte aTrigger[MAX_EMISORES_ULTRASONIDOS] =
						{PIN_TRIGGER_SAPPO_DER_1, PIN_TRIGGER_SAPPO_DER_2, PIN_TRIGGER_SAPPO_DER_3,
						 PIN_TRIGGER_SAPPO_DER_4, PIN_TRIGGER_SAPPO_DER_5, PIN_TRIGGER_SAPPO_DER_6,
						 PIN_TRIGGER_SAPPO_IZQ_1, PIN_TRIGGER_SAPPO_IZQ_2, PIN_TRIGGER_SAPPO_IZQ_3,
						 PIN_TRIGGER_SAPPO_IZQ_4, PIN_TRIGGER_SAPPO_IZQ_5, PIN_TRIGGER_SAPPO_IZQ_6};
sPaquete paquete[MAX_BALIZAS];
FiltroKalman2D fk;       // FiltroKalman para 1 dimension
FiltroKalman1D fkRuedaI; // FiltroKalman para 1 dimension
Vec2f out, input;

double SetpointVal[2], Setpoint[2], Input[2], Output[2];

int SensorEmisor = EMISION_CONJUNTA;
int sensor_baliza[2] = {-1, -1};

Kalman myFilterX(0.125, 32, 1023,
                 0); // suggested initial values for high noise filtering
Kalman myFilterY(0.125, 32, 1023,
                 0); // suggested initial values for high noise filtering
                     // Kalman myFilterY(0.125, 32, 1023, 0); //suggested
                     // initial values for high noise filtering

float KalmanX, KalmanY;
float MediaX, MediaY;
float MedidaX, MedidaY;
float filtroX, filtroY;
float filtroX_media, filtroY_media;
float filtroX_EMA, filtroY_EMA;
float filtroX_FIR, filtroY_FIR;
//int filtro = KALMAN1 | MEDIA | EMA | MEDIA_EVOLUTIVA | MEDIA_COMPENSADA;
int filtro = KALMAN2 | MEDIA_EVOLUTIVA;
int algoKalman = KALMAN2;

Kalman klmRev[2] = {Kalman(0.125, 32, 1023, 0), Kalman(0.125, 32, 1023, 0)};
#define WINDOWS_SIZE 10
MeanFilter<float> filtroMediaX(WINDOWS_SIZE);
MeanFilter<float> filtroMediaY(WINDOWS_SIZE);

sPaqueteRF433 paqueteRF433;
/* SAPPO Configuración **********************************************************************************/


void sBaliza::print() {
  Serial.print(F("ID Baliza "));
  Serial.println(id_baliza);
  Serial.print(F("ID Habitacion "));
  Serial.println(id_habitacion);
  Serial.print("X ");
  Serial.println(X);
  Serial.print("Y ");
  Serial.println(Y);
  Serial.print("Z ");
  Serial.println(Z);
  Serial.print(F("Gradros de cobertura "));
  Serial.println(grados_cobertura);
  Serial.print(F("N?mero sensores "));
  Serial.println(numero_sensores);
  Serial.print(F("Direcci?n "));
  Serial.println(direccion);
}

float Tiempo2Distancia(long Tiempo) { return (1.0 * Tiempo * 0.0346); } // 0.0343 cm/us

bool RecuperarMedidasBalizas(int algoritmo, bool salida)
{
  float minimo, medida[2], media, maximo;
  int medidas, id_baliza_x = 0, id_baliza_y = 0;
  boolean timeout;
  int baliza1, baliza2;

  minimo = 999;
  maximo = 0;
  media = 0;
  medidas = 0;

  // Recuperamos dos medidas de sensores contrapuestos v?lidos para
  // triangulaci?n
  //timeout = RecuperarMedidaMultiple(SensorEmisor, LOG_MEDIDAS | LOG_LECTURAS);
  timeout = RecuperarMedidaMultiple(SensorEmisor, false);

  // Si timeout = true implica que no hemos podido recuperar dos medidas v?lidas
  // para triangular
  if (!timeout)
  {
    // Primero comprobamos que los identificadores de las balizas son correctas
    if ((paquete[0].id_baliza != paquete[1].id_baliza) && (paquete[1].id_baliza+paquete[1].id_baliza != 0))
    {
        baliza1 = (paquete[0].id_baliza == 1)?0:1;
        baliza2 = (baliza1 == 0)?1:0;

      // Convertimos el tiempo a cm
        medida[0] = Tiempo2Distancia(paquete[baliza1].tiempo);
        medida[1] = Tiempo2Distancia(paquete[baliza2].tiempo);

        sensor_baliza[0] = paquete[baliza1].num_sensor;
        sensor_baliza[1] = paquete[baliza2].num_sensor;

      //Salida EXCEL
	  //plot(paquete[0].tiempo/10, paquete[1].tiempo/10); Serial.println("");

      // Verificamos si las dos medidas son correctas
      if (((medida[0] > 10) && (medida[0] < 1000)) &&
          ((medida[1] > 10) && (medida[1] < 1000)))
      {
    	  MedidaX = medida[0];
    	  MedidaY = medida[1];

    	  if (filtro & KALMAN1)
    	  {
			  filtroX = myFilterX.getFilteredValue(medida[0]);
			  filtroY = myFilterY.getFilteredValue(medida[1]);
			  if (salida)
			  {
				Serial.print(filtroX);
				Serial.print(",");
				Serial.print(filtroY);
			  }
    	  }
    	  if (filtro & KALMAN2)
    	  {
			  input[0] = medida[0];
			  input[1] = medida[1];
			  fk.update(input);
			  out = fk.getEstimation();
			  if (salida)
			  {
				Serial.print(out[0]);
				Serial.print(",");
				Serial.print(out[1]);
			  }
    	  }
    	  if (filtro & MEDIA)
    	  {
			  filtroX_media = filtroMediaX.AddValue(medida[0]);
			  filtroY_media = filtroMediaY.AddValue(medida[1]);
			  if (salida)
			  {
				Serial.print(filtroX_media);
				Serial.print(",");
				Serial.print(filtroY_media);
			  }
    	  }
    	  if (filtro & MEDIA_EVOLUTIVA)
    	  {
    		  if (MediaX == 0)
    			  MediaX = medida[0];
    		  else
    			  MediaX = (MediaX+MedidaX) /2;
    		  if (MediaY == 0)
    			  MediaY = medida[1];
			  else
				  MediaY = (MediaY+MedidaY) /2;

			  if (salida)
			  {
				Serial.print(MediaX);
				Serial.print(",");
				Serial.print(MediaY);
			  }
    	  }
    	  if (salida == SALIDA_COMPLETA)
    		  LOG_DEBUG("MED:",paquete[0].id_baliza, paquete[1].id_baliza, paquete[0].tiempo, paquete[1].tiempo);
  		return true;
      } //if medida
    } //if paquete
  } //if timeout
  return false;
}

boolean RecuperarMedidaMultiple(int emisor, int LOG) {
  paquete[0].id_baliza = 0;
  paquete[1].id_baliza = 0;
  // radio.write(&paquete, sizeof(paquete));
  EnviarMensaje433Mhz(0);
  EnviarPulsoUltrasonidos(emisor);

  radio.startListening();

  unsigned long started_waiting_at = millis();
  bool timeout = false;

  float medida;
  int numero_medidas = 0;
  while (!timeout && (numero_medidas < NUM_BALIZAS_RECUPERAR)) // Esperamos
  {
    while ((!radio.available()) && !timeout) // Esperamos
    {
    	if (millis() - started_waiting_at > TIMEOUT_MEDIDA_US) {
    		timeout = true;
    		//Serial.println("err");
      }
    }

    if (!timeout) { // Leemos el mensaje recibido
      unsigned long got_time;
      radio.read(&paquete[numero_medidas], sizeof(sPaquete));
      radio.flush_rx();
      // medida = 1.0 * paquete[numero_medidas].tiempo / 29.2;   //convertimos a
      // distancia, en cm paquete[numero_medidas].tiempo = medida;

      if (LOG & LOG_MEDIDAS)
      {
    	  if (paquete[numero_medidas].id_baliza == 2)
    		  LOG_DEBUG("LOG_MED:",paquete[numero_medidas].id_baliza, paquete[numero_medidas].num_sensor, 0, 0);
      }
      numero_medidas++;
    }
  }

  if (!timeout)
  {
    int baliza2, baliza1;
    if (paquete[0].id_baliza == 1)
    {
        baliza1 = 0;
        baliza2 = 1;
    }
    else
    {
        baliza1 = 1;
        baliza2 = 0;
    }
    if (LOG & LOG_LECTURAS)
    {
      Serial1.print("lectura: ");
      Serial1.print(paquete[baliza2].tiempo);
      Serial1.print(" - ");
      Serial1.print(paquete[baliza2].id_baliza);
      Serial1.print(" , ");
      Serial1.print(paquete[baliza1].tiempo);
      Serial1.print(" - ");
      Serial1.println(paquete[baliza1].id_baliza);
    }
}

  radio.stopListening();

  return timeout;
}
void InicializarRadio()
{
	  // Inicializar RF 433MHz
	  vw_set_tx_pin(PIN_RF);
	  vw_setup(2500); // Bits per sec
	  // vw_rx_start();       // Start the receiver PLL running

	  //Inicializar nRF24L01
	  radio.begin();
	  //radio.setPALevel(RF24_PA_HIGH);
	  //radio.openReadingPipe(0, broadcast);
	  radio.openReadingPipe(1, pipe1);
	  radio.openReadingPipe(2, pipe2);

	  radio.setChannel(108);
	  radio.setRetries(3, 3);
	  radio.setAutoAck(true);
}

void InicializarSAPPO_us()
{
	  for (int i = 0; i < MAX_EMISORES_ULTRASONIDOS; i++) {
	    pinMode(aTrigger[i], OUTPUT);
	  }}

void CargarDatosBalizas() {
  sBaliza Baliza;
  Baliza.codigo = 1;
  Baliza.id_baliza = 1;
  Baliza.id_habitacion = 1;
  Baliza.grados_cobertura = 90;
  Baliza.direccion = 1;
  Baliza.numero_sensores = 4;
  Baliza.X = 10;
  Baliza.Y = 10;
  Baliza.Z = 10; // Altura de los sensores desde el suelo
  ListaBalizas.add_head(Baliza);

  Baliza.codigo = 2;
  Baliza.id_baliza = 2;
  Baliza.id_habitacion = 1;
  Baliza.grados_cobertura = 90;
  Baliza.direccion = 1;
  Baliza.numero_sensores = 4;
  Baliza.X = 210;
  Baliza.Y = 10;
  Baliza.Z = 10;
  ListaBalizas.add_head(Baliza);
}

void EnviarMensaje433Mhz(int lectura) {
  paqueteRF433.id_robot = ID_ROBOT_RODI;
  paqueteRF433.operacion = ID_OPERACION_MEDIDA;

  // digitalWrite(13, true); // Flash a light to show transmitting

  vw_send((uint8_t *)&paqueteRF433, 2);

  Espera(35, 0, OP_INICIAR);

  vw_wait_tx(); // Wait until the whole message is gone duración= 38400 us

//  while(vw_tx_active())
//	  SoftwareServo::refresh();

}

void EnviarPulsoUltrasonidos(int emisor) {
  long tiempo;
  int distanceCm;
  if (emisor != EMISION_CONJUNTA) {
    digitalWrite(aTrigger[emisor],
                 LOW); /* Por cuesti?n de estabilizaci?n del sensor*/
    delayMicroseconds(5);
    digitalWrite(aTrigger[emisor], HIGH); /* env?o del pulso ultras?nico*/
    delayMicroseconds(15);
    digitalWrite(aTrigger[emisor], LOW); /* env?o del pulso ultras?nico*/
  } else {
    for (int i = 0; i < MAX_EMISORES_ULTRASONIDOS; i++)
        digitalWrite(aTrigger[i], LOW); /* Por cuestion de estabilizacion del sensor*/
    delayMicroseconds(5);
    for (int i = 0; i < MAX_EMISORES_ULTRASONIDOS; i++)
        digitalWrite(aTrigger[i], HIGH); /* envio del pulso ultrasonico*/
    delayMicroseconds(15);
    for (int i = 0; i < MAX_EMISORES_ULTRASONIDOS; i++)
        digitalWrite(aTrigger[i], LOW); /* envio del pulso ultrasonico*/
  }

  /* Cálculo de distancia en cm
  tiempo = pulseIn(ECHO1, HIGH)+1;

  distanceCm = tiempo * 10 / 292/ 2;   //convertimos a distancia, en cm

  Serial.println(distanceCm);
  */
}

bool Espera(unsigned long ms, int contador, int op) {
#define MAX_US 4294967295

  static unsigned long us_ini[10] = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
  unsigned long us_actual[10];

  us_actual[contador] = micros();

  if (op == OP_INICIAR)
    us_ini[contador] = micros();
  else {
    if (us_actual[contador] < us_ini[contador]) {
      us_actual[contador] = MAX_US - us_ini[contador] + us_actual[contador];
      us_ini[contador] = 1;
    }

    if (us_actual[contador] - us_ini[contador] >= ms * 1000) {
      us_ini[contador] = 0;
      return false;
    } else
      return true;
  }
}
