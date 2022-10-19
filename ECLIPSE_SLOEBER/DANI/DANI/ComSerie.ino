#include "pines.h"

//#define PIN_RETROCESO  10 //Blanco

#define GRADOS    0
#define MS        1
#define SERVO_DIR    26 //Servo direccion
#define MAX_SENSOR_DISTANCIA 4
#define MIN_POS_SERVO 18
#define MAX_POS_SERVO 24

int MOTOR = LOW;
int VELOCIDAD = 0;

bool ControlPosicionActivo = false;
bool ControlLimitesOffActivo = false;
bool ControlLimitesActivo = true;

//Guarda el valor de los servos rotacionales => dirección de giro
byte DirServo[6] = { VALOR_MEDIO, VALOR_MEDIO, VALOR_MEDIO, VALOR_MEDIO, VALOR_MEDIO, VALOR_MEDIO };

//Transforma los nº de servos en números de 0-6
extern byte RecNumServoRot(int servo);

int ComprobarCRC(int CRC, char *cad)
{
  int c = 0;
  int i = 0;
  
  while (cad[i] != 0)
  {
    c += cad[i++];
  }
  if (c%100 == CRC)
    return 1;
   else
     return 0;
}

int LeerCadena(int *i, char *Cadena)
{
  char c;
  
  while (Serial.available() > 0)
  {
    c = Serial.read();
    if (*i < MAX_LON_CADENA-2)
    {
      switch (c)
      {
        case '\r':
          break;
        case '\n':
        case '.':
        {
            Cadena[*i] = 0;
            *i = 0;
            return 1; //FIN_LECTURA
        }
        default:
          Cadena[(*i)++] = c;
          Cadena[*i] = 0;
      }
    }
    else
    {
        Cadena[0] = 0;
        *i = 0;
        return 2;
    }
 }
 return 0;
}

void ProcesarCadena(char *Cadena)
{
	//Letras escogidas: Aa,b,cC,dD,eE,f,-g,-h,iI,-j,-k,L,mM,-�,o,Pp,-q,rR,sS,tT,U,vV,-w,-y,Z,1,2
  char cCar;
  int i;
  int iPosFin;
  int iNumServo;
  int iNumSensor;
  int iValor;
  int iModo;
  long CRC;
  int p;
  
  cCar = Cadena[0];
  
  if (cCar == '@')
  {
    CRC = RecValor(Cadena, 1, ':', &iPosFin);
    p = iPosFin;
    if (!ComprobarCRC(CRC, Cadena+p++)) return;
    
    cCar = Cadena[p++];
    switch (cCar)
    {
	  case 'b':
      { //Control alimentación base HIGH -> Apaga base
        int d;
        d = RecValor(Cadena, p, ';', &iPosFin);

        digitalWrite(PIN_ALIMENTACION_BASE, d);
        ActivarBase();
        break;
      }
      case 'c': 
      { //Control alimetación cuerpo
        int d;
        d = RecValor(Cadena, p, ';', &iPosFin);

        digitalWrite(PIN_ALIMENTACION_CUERPO, d);
        ActivarCuerpo();
        break;
      }
	  case 'C':
	  { //Control alimetación cabeza
		  int d;
		  d = RecValor(Cadena, p, ';', &iPosFin);

		  digitalWrite(PIN_ALIMENTACION_CABEZA, d);
		  ActivarCabeza();
		  break;
	  }
      case 'o':
      { //Control de posición
          int d;
          d = RecValor(Cadena, p, ';', &iPosFin);

          ControlPosicionActivo = d;
          break;
      }
      case 'L':
      { //Control de posición
          int d;
          d = RecValor(Cadena, p, ';', &iPosFin);

          ControlLimitesOffActivo = d;
          break;
      }
      case 'Z':
      { //Control de posición
          int d;
          d = RecValor(Cadena, p, ';', &iPosFin);

          ControlLimitesActivo = d;
          break;
      }
      case 'A':
	  { //Arranque del motor
		  int v;
		  int i;
		  v = RecValor(Cadena, p, ';', &iPosFin);

		  for (i = 0; i < v; i++)
		  {
			  analogWrite(PIN_PWM_MOTOR, i);
			  delay(5);
		  }
		  VELOCIDAD = v;
		  /*digitalWrite(PIN_MOTOR, HIGH);
		  delay(100);
		  analogWrite(PIN_MOTOR, v);*/
		  MOTOR = HIGH;
		  break;
	  }
	  case 'P':
	  { //Parada del motor
		  if (MOTOR == HIGH)
			  ApagadoMotorProgresivo();
		  break;
	  }
	  case 'd':
      { //Control de dirección
        int d;
        d = RecValor(Cadena, p, ';', &iPosFin);

        AsignarServo(SERVO_DIR, d, GRADOS);
        break;
      }
      case 'f': 
      { //Avance-Retroceso
        int f;
        f = RecValor(Cadena, p, ';', &iPosFin);
		if (f)
			digitalWrite(PIN_AVANCE_RETROCESO, HIGH);
		else
			digitalWrite(PIN_AVANCE_RETROCESO, LOW);
        break;
      }
      case 'v': 
      { //Control de velocidad de motor
        int v;

        v = RecValor(Cadena, p, ';', &iPosFin);

		if (MOTOR == LOW) break;
		
		if (v == 0)
          digitalWrite(PIN_PWM_MOTOR, LOW);
        else
			analogWrite(PIN_PWM_MOTOR, v);
        break;
      }
	  case 'D':
	  { //Lectura de los sensores de distancia
		  iNumSensor = RecValor(Cadena, p, ';', &iPosFin);

		  Serial.print("D->");
		  Serial.print(iNumSensor);
		  Serial.print(",");
		  Serial.print(DistanciaCm[iNumSensor]);
		  Serial.println(";");
		  break;
	  }
	  case 'a':
      { //Lectura del ángulo de articulación
        iNumServo = RecValor(Cadena, p, ';', &iPosFin);

        Serial.print("A->");
        Serial.print(iNumServo);
        Serial.print(",");
        Serial.print(analogRead(pinPotenciometro(iNumServo)));
        Serial.println(";");
        break;
      }
      case 'p': 
      { //Posicion inmediata
        cCar = Cadena[p++];
        
        iNumServo = RecValor(Cadena, p, ',', &iPosFin);
        iValor = RecValor(Cadena, iPosFin + 1, ';', &iPosFin);

        if (cCar == 'g')
            iModo = GRADOS;
        else if (cCar == 'r')
        {   //Reseteamos la posición de parada
            iModo = GRADOS;
            GrabarValorParada(iNumServo, iValor);
        }
        else
           iModo = MS;
        
        AsignarServoControl(iNumServo, iValor, iModo);

        break;
      }
      case 'm':
      { // Movimiento temporizado
        cCar = Cadena[p++];
        if (cCar == 'g')
          iModo = GRADOS;
        else
           iModo = MS;
        
        LOG2("","CARGA_MOV");
  
        if (iPosSec < MAX_SEC-1)
        {
          Secuencia[iPosSec].BNumMov = RecValor(Cadena, p, '|', &iPosFin);
          RecCadena(Cadena, iPosFin+1, '|', &iPosFin); //Descripción
          Secuencia[iPosSec].iTiempo = RecValor(Cadena, iPosFin+1, '|', &iPosFin);
          LOG2int("tiempo->", Secuencia[iPosSec].iTiempo);
    
          CRC = 0;
          for (i=0; i<=22; i++)
            Secuencia[iPosSec].pos[i] = SIN_ASIGNAR;
          for (i=0; i<=22; i++)
          {
            iNumServo = RecValor(Cadena, iPosFin+1, ',', &iPosFin);
            CRC += iNumServo;
            Secuencia[iPosSec].pos[iNumServo] = RecValor(Cadena, iPosFin+1, ';', &iPosFin);
            CRC += Secuencia[iPosSec].pos[iNumServo];
            LOG2int(",",Secuencia[iPosSec].pos[iNumServo]);
          }
          if ((CRC%32760) == RecValor(Cadena, iPosFin+1, '|', &iPosFin))
          {
            iPosSec++;
            Serial.print(">SEC_OK-");
            Serial.println(iPosSec);
          }
          else
          {
            Serial.print(">SEC_ERROR-");
            Serial.println(iPosSec);
          }
        }
        else
            Serial.print(">SEC_ERROR_MAX_SEC");
        break;
      }
      case 'M': //Movimiento de servo rotacinoal indicando valor de potenci�metro
      {
          //Cambiamos el valor de la posicion del potenciometros de parada
          cCar = Cadena[p];

          int iPorcPotencia = 100;
          iNumServo = RecValor(Cadena, p, ',', &iPosFin);
          iValor = RecValor(Cadena, iPosFin + 1, ',', &iPosFin);
          iPorcPotencia = RecValor(Cadena, iPosFin + 1, ';', &iPosFin);

          EstablecerMovimientoServoRot(iNumServo, iValor, iPorcPotencia);

          break;
      }
      case 'r':
      {
          iEstado = RUN;
          iNumMovActivo = RecValor(Cadena, p, ';', &iPosFin);
          Serial.print(">RUN_OK-");
          Serial.println(iNumMovActivo);
          break;
      }
      case 'R':
      {
          //Cambiamos el valor de la posición del potenciómetros de parada
          cCar = Cadena[p++];

          iNumServo = RecValor(Cadena, p, ',', &iPosFin);
          iValor = RecValor(Cadena, iPosFin + 1, ';', &iPosFin);

          CambiarPosicionParada(iNumServo, iValor);
          break;
      }
      case 'E':
      { //Ejecutar movimiento temporizado para servos posicionales
    	  for (int i=2; i<=16; i++)
    	  {
    		  int indServo = RecNumServo(i);
    		  //Si tiene tiempo programado y no se est� moviendo
    		  if ((aPosServos[indServo].ms_tiempo_mov > 0) && !aPosServos[indServo].MovTemporizadoActivo)
    		  {
    			  aPosServos[indServo].ms_inicial = millis();
    			  aPosServos[indServo].ms_final = aPosServos[indServo].ms_inicial + aPosServos[indServo].ms_tiempo_mov;
    			  aPosServos[indServo].MovTemporizadoActivo = true;
    		  }
    	  }
    	  break;
      }
      case 'e':
      {
          //Cambiamos el valor de la posicion de parada de los servos rotacionales
          cCar = Cadena[p++];

          iNumServo = RecValor(Cadena, p, ',', &iPosFin);
          iValor = RecValor(Cadena, iPosFin + 1, ';', &iPosFin);

          CambiarValorServoParada(iNumServo, iValor);
          break;
      }
      case 'S':
      {
          setup();
          break;
      }
      case 's':
      {
        iEstado = STOP;
        iNumMovActivo = SIN_ASIGNAR;
        iNumSecActiva = SIN_ASIGNAR;
        Serial.println(">STOP_OK");
        break;
      }
      case 't':
      {
        iEstado = STOP;
        iPosSec = 0;
        iNumMovActivo = SIN_ASIGNAR;
        iNumSecActiva = SIN_ASIGNAR;
        Serial.println(">RESET_OK");
        break;
      }
      case 'T':
      {
    	  int iGradosSeg;
		  //Cambiamos el valor de la posición del potenciómetros de parada
		  cCar = Cadena[p];

		  iNumServo = RecValor(Cadena, p, ',', &iPosFin);
		  iValor = RecValor(Cadena, iPosFin + 1, ',', &iPosFin);
		  iGradosSeg = RecValor(Cadena, iPosFin + 1, ';', &iPosFin);

		  int indServo = RecNumServo(iNumServo);

		  if (aPosServos[indServo].MovTemporizadoActivo)
		  {
			  aPosServos[indServo].MovTemporizadoActivo = false;
			  PararServo(iNumServo);
		  }

		  aPosServos[indServo].iValoIniTemporizado = aPosServos[indServo].iValor;
		  aPosServos[indServo].iValorFinTemporizado = iValor;
		  aPosServos[indServo].ms_tiempo_mov = abs(aPosServos[indServo].iValorFinTemporizado -
				  	  	  	  	  	  	  	  	  	   long(aPosServos[indServo].iValoIniTemporizado))*1000 / iGradosSeg;
		  break;
      }
      case 'i':
      {
        PosicionInicial();
        Serial.println(">POSINI_OK");
        break;
      }
      case 'I': //Cambiamos el valor de la variable Debug
      {
          int d;
          char *msg = RecCadena(Cadena, p, ';', &iPosFin);

          Debug = msg;
          break;
      }
      case 'V':
	  {
		  iNumServo = RecValor(Cadena, p, ';', &iPosFin);

          Serial.print("V->");
          EnviarContadorMarcasRueda();
          Serial.println(";");
          break;
	  }
	  case '1':
	  { //Recuperar valores de todos los sensores de distancia
          Serial.print("1->");
          EnviarDistancias();
          Serial.println(";");
          break;
	  }
	  case '2':
	  { //Lectura de todos los ángulos de articulación
          Serial.print("2->");
          EnviarArticulaciones();
          Serial.println(";");
          break;
	  }
      case 'U':
      { //Lectura unificada de todos los sensores
          Serial.print("U->");
          EnviarArticulaciones();
          Serial.print(",");
          EnviarDistancias();
          Serial.print(",");
          EnviarContadorMarcasRueda();
          Serial.print(",");
          EnviarSensorLinea();
          Serial.print(",");
          EnviarEstadoMotoresServosRot();
          Serial.print(",");
          EnviarEstadoEncendidoReles();
          EnviarEstadoEncendidoCfg();
          Serial.print("=>");
          Serial.print(Debug);
          Serial.println(";");
          break;
      }
    } //switch
  } //if cCar
}

void EnviarEstadoEncendidoCfg()
{
    Serial.print((ControlPosicionActivo) ? 1 : 0);
    Serial.print((ControlLimitesOffActivo) ? 1 : 0);
    Serial.print((ControlLimitesActivo) ? 1 : 0);
}
void EnviarEstadoEncendidoReles()
{
    Serial.print((digitalRead(PIN_ALIMENTACION_CUERPO) == HIGH ? 1 : 0));
    Serial.print((digitalRead(PIN_ALIMENTACION_BASE) == HIGH ? 1 : 0));
    Serial.print((digitalRead(PIN_ALIMENTACION_CABEZA) == HIGH ? 1 : 0));
}

void EnviarDistancias()
{
    for (int i = 0; i < MAX_SENSOR_DISTANCIA; i++)
    {
        if (i != 0) Serial.print(",");
        Serial.print(DistanciaCm[i]);
    }
}

void EnviarArticulaciones()
{
    for (int i = MIN_POS_SERVO; i <= MAX_POS_SERVO; i++)
    {
        if (i != MIN_POS_SERVO) Serial.print(",");
        Serial.print(analogRead(pinPotenciometro(i)));
    }
}

void EnviarSensorLinea()
{
    Serial.print((digitalRead(PIN_SENSOR_LINEA_L) == HIGH ? 1 : 0));
    Serial.print((digitalRead(PIN_SENSOR_LINEA_C) == HIGH ? 1 : 0));
    Serial.print((digitalRead(PIN_SENSOR_LINEA_R) == HIGH ? 1 : 0));
}

void EnviarContadorMarcasRueda()
{
    Serial.print(ContadorMarcas);
}


int RecValor(char *Cadena, int iPosIni, char cDelimitador, int *iFinPos)
{
  char cTmp[50] = "\0";
  char cCar;
  int i,j;
  
  i = iPosIni;
  j = 0;
  cCar = Cadena[i];
  while (cCar != cDelimitador)
  {
    cTmp[j++] = cCar;
    cCar = Cadena[++i];
  }
  cTmp[j] = 0;
  *iFinPos = i;
  return atoi(cTmp);
}
char * RecCadena(char *Cadena, int iPosIni, char cDelimitador, int *iFinPos)
{
  static char cTmp[50] = "\0";
  char cCar;
  int i,j;
  
  cTmp[0] = 0;
  i = iPosIni;
  j = 0;
  cCar = Cadena[i];
  while (cCar != cDelimitador)
  {
    cTmp[j++] = cCar;
    cCar = Cadena[++i];
  }
  cTmp[j] = 0;
  *iFinPos = i;
  return cTmp;
}

void ApagadoMotorProgresivo()
{
    int i;
    for (i = VELOCIDAD; i >= 50; i--)
    {
        analogWrite(PIN_PWM_MOTOR, i);
        delay(2);
    }
    analogWrite(PIN_PWM_MOTOR, 0);
    digitalWrite(PIN_PWM_MOTOR, LOW);
    MOTOR = LOW;
}






