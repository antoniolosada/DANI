#define MIN_SERVO_POS   16
#define MAX_SERVO_POS	25

#define MS_POR_GRADO	60
#define MIN_TIEMPO_DESCONEX  600

#define VALOR_MEDIO		100
#define NUM_POSICIONES	255

#define ASCENDENTE				1
#define DESCENDENTE				0
#define SIN_ACCION				-1

#define MAYOR_MEDIO		1
#define MENOR_MEDIO		-1

#define SERVO_ROT_SUBIR		5
#define SERVO_ROT_BAJAR		175

#define MAX_CONTADOR_FUERA_LIMITES  3

#define TIEMPO_DESCONEX_SERVO_ROT_MS 3000
#define VALOR_SERVO_ROT_ALTO 175
#define VALOR_SERVO_ROT_BAJO 5

//Números de los servos comunicados desde PC
enum Posiciones {
	mano_derecha_pulgar = 2,
	mano_derecha_indice = 3,
	mano_derecha_medio = 4,
	mano_derecha_anular = 5,
	mano_derecha_menique = 6,
	mano_derecha_muneca = 7,
	mano_izquierda_pulgar = 8,
	mano_izquierda_indice = 9,
	mano_izquierda_medio = 10,
	mano_izquierda_anular = 11,
	mano_izquierda_menique = 12,
	mano_izquierda_muneca = 13,
	boca = 14,
	guinada = 15,
	cabeceo = 16,
	hombro_cuerpo_derecho = 18,
	hombro_brazo_derecho = 19,
	biceps_derecho = 20,
	hombro_cuerpo_iquierdo = 22,
	hombro_brazo_iquierdo = 23,
	biceps_izquierdo = 24,
	direccion_servo = 26,
	avance = 27
};

#define NUM_SERVOS_ROT	6
#define NUM_SERVOS		16		
#define NUM_VECES_FUERA_TOLERANCIA 4

#define MULTIPLICADOR_TOLERANCIA_APAGADO	2

struct sInfoServosRot
{
	byte NumServo;
	byte Direccion;
	byte PosParada;
	int MinPos;
	int MaxPos;
	byte Tolerancia;
	int ValorPotenciometroParada;
	byte PosActual;
	byte Reposicionar;
	byte NumVecesFueraTolerancia;
	int ValorPotInicial;
	int ValorPotFinal;
	int PorcentajePotencia;
	bool MovimientoActivo;
};

struct sInfoServos
{
	byte NumServo;
	byte PosInicial;
	byte MinPos;
	byte MaxPos;
};

//*****************************  CFG   ************************************************************************************************************************************************************

//Valores de configuración servos rotacionales
sInfoServosRot InfoServosRot[NUM_SERVOS_ROT] =
{
   {hombro_cuerpo_derecho,ASCENDENTE, 108,844,970,10,0,0,0,0,0,0,false},
   {hombro_brazo_derecho,ASCENDENTE, 109,300,580,20,0,0,0,0,0,0,false},
   {biceps_derecho,ASCENDENTE, 70,140,560,10,0,0,0,0,0,0,false},
   {hombro_cuerpo_iquierdo,DESCENDENTE, 80,555,748,10,0,0,0,0,0,0,false},
   {hombro_brazo_iquierdo,ASCENDENTE, 78,510,719,10,0,0,0,0,0,0,false},
   {biceps_izquierdo,ASCENDENTE, 75,359,547,10,0,0,0,0,0,0,false} };


//Valores de configuración servos normales
sInfoServos InfoServos[NUM_SERVOS] =
{
  {mano_derecha_pulgar, 85, 27, 160},
  {mano_derecha_indice, 85, 16, 178},
  {mano_derecha_medio, 85, 23, 158},
  {mano_derecha_anular, 85, 13, 178},
  {mano_derecha_menique, 85, 43, 178},
  {mano_derecha_muneca, 178, 43, 178},
  {mano_izquierda_pulgar, 163, 51, 178},
  {mano_izquierda_indice, 136, 41, 155},
  {mano_izquierda_medio, 115, 0, 125},
  {mano_izquierda_anular, 42, 0, 178},
  {mano_izquierda_menique, 178, 35, 178},
  {mano_izquierda_muneca, 118, 0, 178},
  {boca, 92, 90, 112},
  {guinada, 65, 15, 135},
  {cabeceo, 12, 1, 105},
  {direccion_servo, 87, 1, 155}
};
#define IND_INFO_SERVOS_DIR	15



//*****************************  CFG   ************************************************************************************************************************************************************

//Convierte los nº de servos interface PC a 0..5
byte RecNumServoRot(int servo)
{ //Servos rotacionales
	int i;
	if (servo < 22)
		return servo - 18;
	else
		return servo - 22 + 3;
}
byte RecNumServo(int servo)
{ //Los nº de servos normales comienzan en 2
	return servo - 2;
}

//Devuelve un valor normalizado entre 0 y NUM_POSICIONES
int LeerPosicionArticulacion(int ns)
{
	int valor = analogRead(pinPotenciometro(ns));

	float valor_unidad = (float)NUM_POSICIONES/(InfoServosRot[RecNumServoRot(ns)].MaxPos - InfoServosRot[RecNumServoRot(ns)].MinPos + 1);

	return (float)(InfoServosRot[RecNumServoRot(ns)].MaxPos - valor) * valor_unidad;
}

//Devuelve el pin asignado a cada nº de servo del programa PC
int pin(int iNumServo)
{
  switch (iNumServo+2)
  {
    case 2: return PIN_PULGAR_DER; //pulgar
    case 3: return PIN_INDICE_DER; //Incide 167-33
    case 4: return PIN_MEDIO_DER; //Corazón 159-55
    case 5: return PIN_ANULAR_DER; //Anular 178-57
    case 6: return PIN_MENIQUE_DER; //Meñique
    case 7: return PIN_GIRO_MANO_DER; //Giro Muñeca
    case 8: return PIN_PULGAR_IZQ; //pulgar
    case 9: return PIN_INDICE_IZQ; //indice
    case 10: return PIN_MEDIO_IZQ; //medio
    case 11: return PIN_ANULAR_IZQ; //anular
    case 12: return PIN_MENIQUE_IZQ; //Meñique
    case 13: return PIN_GIRO_MANO_IZQ; //muñeca
    case 14: return PIN_BOCA; //boca
    case 15: return PIN_CABEZA_GUINADA; //Mivimiento lateral cabeza
    case 16: return PIN_CABEZA_CABECEO; //Subir-Bajar cabeza
	//Servos rotacionales
    case 18: return PIN_HOMBRO_DER; //Hombro-cuerpo der
    case 19: return PIN_BICEPS_DER; //Hombro-brazo der
    case 20: return PIN_BRAZO_DER; //Codo der
    case 22: return PIN_HOMBRO_IZQ; //Hombro-cuerpo izq
    case 23: return PIN_BICEPS_IZQ; //Hombro-Brazo izq
    case 24: return PIN_BRAZO_IZQ; //Biceps izq
	case 26: return PIN_DIRECCION; //Servo dirección - blanco
  }
  return 0;
}

//Pin de los potenciómetros de cada articulación
int pinPotenciometro(int iNumServo)
{
  switch (iNumServo)
  {
	case 18: return PIN_ANALOG_POT_HOMBRO_DER;
	case 19: return PIN_ANALOG_POT_BRAZO_DER;
    case 20: return PIN_ANALOG_POT_CODO_DER;

    case 22: return PIN_ANALOG_POT_HOMBRO_DER;
    case 23: return PIN_ANALOG_POT_BRAZO_DER;
    case 24: return PIN_ANALOG_POT_CODO_DER;
  }
}

bool ServoRotacional(int ns)
{
	if ((ns >= 18) && (ns <= 24) && (ns != 21))
		return true; //Servo de rotaci�n cont�nua
	else
		return false; //Servo de posici�n
}

//Establecer como posición inicial la posición actual (Arduino)
void PosicionInicial()
{
	ControlPosicionActivo = false;
	//Servos rotaci�n cont�nua
	for (int i = 0; i < NUM_SERVOS_ROT; i++)
	{
		AsignarServo(InfoServosRot[i].NumServo, InfoServosRot[i].PosParada, GRADOS);
		InfoServosRot[i].PosActual = InfoServosRot[i].PosParada;
		InfoServosRot[i].ValorPotenciometroParada = analogRead(pinPotenciometro(InfoServosRot[i].NumServo));
		InfoServosRot[i].Reposicionar = SIN_ASIGNAR;
		InfoServosRot[i].MovimientoActivo = false;
	}

	//Servos normales
	for (int i = 0; i < NUM_SERVOS; i++)
		AsignarServo(InfoServos[i].NumServo, InfoServos[i].PosInicial, GRADOS);
}

void ActivarCabeza()
{
	for (int i = 14; i <=16; i++)
		AsignarServo(i, aPosServos[i-2].iValor, aPosServos[i-2].iUnidad);
}

void ActivarBase()
{
	AsignarServo(SERVO_DIR, aPosServos[SERVO_DIR-2].iValor, aPosServos[SERVO_DIR-2].iUnidad);
}

void ActivarCuerpo()
{
	int i;

	for (i = 2; i <=13; i++)
		AsignarServo(i, aPosServos[i-2].iValor, aPosServos[i-2].iUnidad);

	for (i = 18; i <=24; i++)
		AsignarServo(i, aPosServos[i-2].iValor, aPosServos[i-2].iUnidad);
}


void GrabarValorParada(int iNumServo, int iValor)
{
	//Grabamos el valor ser servo para que se encuentre parado
	InfoServosRot[RecNumServoRot(iNumServo)].PosParada = iValor;
}

bool EstamosParandoServoRot(int iNumServo, int iValor)
{
	return (iValor == InfoServosRot[RecNumServoRot(iNumServo)].PosParada);
}

//Asignamos valor desde el interface de control
void AsignarServoControl(int iNumServo, int iValor, int iModo)
{
	//Si se asigna valor de movimiento en un servo rotacional del el interface de control hay que parar el reposicionamiento
	//La posición de parada es la actual
	if (ServoRotacional(iNumServo))
	{
		//Solo cambio el valor del potenciómetro de posición si estoy cambiando la posición desde el interface de control
		InfoServosRot[RecNumServoRot(iNumServo)].MovimientoActivo = false;
		InfoServosRot[RecNumServoRot(iNumServo)].NumVecesFueraTolerancia = 0;
		InfoServosRot[RecNumServoRot(iNumServo)].ValorPotenciometroParada = analogRead(pinPotenciometro(iNumServo));
		DirServo[RecNumServoRot(iNumServo)] = iValor;

		if (EstamosParandoServoRot(iNumServo, iValor))
			InfoServosRot[RecNumServoRot(iNumServo)].Reposicionar = SIN_ASIGNAR; //Permitimos que se active el reposicionamiento
		else
			InfoServosRot[RecNumServoRot(iNumServo)].Reposicionar = MOV_CONTROL; //Estamos en movimiento y no se puede activar el reposicionamiento
	}
	else
	{
		aPosServos[RecNumServo(iNumServo)].ms_tiempo_mov = 0; //Desactivamos la programaci�n de movimiento
	}

	AsignarServo(iNumServo, iValor, iModo);
}

void CambiarPosicionParada(int iNumServo, int iPos) //Posición potenciómetros de parada
{
	if (ServoRotacional(iNumServo))
	{
		InfoServosRot[RecNumServoRot(iNumServo)].PosActual = PararServo(iNumServo);
		//Solo cambio la posicion de parada si me paro tras una reasignación
		InfoServosRot[RecNumServoRot(iNumServo)].Reposicionar == SIN_ASIGNAR;
		InfoServosRot[RecNumServoRot(iNumServo)].NumVecesFueraTolerancia = 0;
		InfoServosRot[RecNumServoRot(iNumServo)].ValorPotenciometroParada = iPos;
	}
}
void CambiarValorServoParada(int iNumServo, int iPos) //Cambia el valor de parada de los servos rotacionales
{
	if (ServoRotacional(iNumServo))
	{
		InfoServosRot[RecNumServoRot(iNumServo)].PosActual = PararServo(iNumServo);
		//Solo cambio la posicion de parada si me paro tras una reasignación
		InfoServosRot[RecNumServoRot(iNumServo)].Reposicionar == SIN_ASIGNAR;
		InfoServosRot[RecNumServoRot(iNumServo)].NumVecesFueraTolerancia = 0;
		InfoServosRot[RecNumServoRot(iNumServo)].PosParada = iPos;
	}
}
unsigned long TiempoDesconexion(int iValorActual, int iValorNuevo, bool ServoRotContinua)
{
	int TiempoDesconexion = 0;

	if (ServoRotContinua)
		TiempoDesconexion = TIEMPO_DESCONEX_SERVO_ROT_MS;
	else
		TiempoDesconexion = MIN_TIEMPO_DESCONEX;

	return TiempoDesconexion;
}

//Asignación de valor de servo tanto desde controles internos como desde interface de control
void AsignarServo(int iNumServo, int iValor, int iUnidad)
{
  int iMin, iMax;
  
  iMin = 0;
  iMax = 179;
  int indServo = RecNumServo(iNumServo);
  int iServoLimites = indServo;

  //LOG_DEBUG("S1",iNumServo, iValor, 0, 0);

   if ((iUnidad == GRADOS) && (iNumServo >= 2) && (iNumServo <= 26))
   {
	   //Si es un servo normal sobreescribimos los limites
	   if (!ServoRotacional(iNumServo))
	   {
		   if (iNumServo == SERVO_DIR) iServoLimites = IND_INFO_SERVOS_DIR; //L�mites de la direcci�n
		   iMin = InfoServos[iServoLimites].MinPos;
		   iMax = InfoServos[iServoLimites].MaxPos;
	   }

	   //Asignamos el valor a los servos
       if ((iValor >= iMin) && (iValor <= iMax))
       {
    	   int pin = aPosServos[indServo].pin;
    	   if (pin > 0)
    	   {
			   if (aPosServos[indServo].Conectado)
			   {
				   aServo[indServo].write(iValor);
				   aPosServos[indServo].ms_desconexion = millis()+TiempoDesconexion(aPosServos[indServo].iValor, iValor, ServoRotacional(iNumServo));
			   }
			   else
			   {
				   cli();
				   aServo[indServo].attach(pin);
				   aServo[indServo].write(iValor);
				   sei();
				   aPosServos[indServo].Conectado = true;
				   aPosServos[indServo].ms_desconexion = millis()+TiempoDesconexion(aPosServos[indServo].iValor, iValor, ServoRotacional(iNumServo));
			   }
			   aPosServos[indServo].iValor = iValor;
			   aPosServos[indServo].iUnidad = iUnidad;
    	   }
       }

	   if (ServoRotacional(iNumServo))
	   {
		   InfoServosRot[RecNumServoRot(iNumServo)].PosActual = iValor;
		   if (EstamosParandoServoRot(iNumServo, iValor))
		   {
			   InfoServosRot[RecNumServoRot(iNumServo)].Reposicionar = SIN_ASIGNAR;
			   InfoServosRot[RecNumServoRot(iNumServo)].NumVecesFueraTolerancia = 0;
			   aPosServos[indServo].ms_desconexion = millis();
		   }
	   }
   }
   else
   {
     //aServo[iNumServo].writeMicroseconds(iValor);
   }
}

int FueraDeRangos(int iNumServo, int valor, int dir, int min, int max)
{
	if (dir == ASCENDENTE)
	{
		if ((valor < min) && (DirServo[RecNumServoRot(iNumServo)] > VALOR_MEDIO))
			return MAYOR_MEDIO;
		else if ((valor > max) && (DirServo[RecNumServoRot(iNumServo)] < VALOR_MEDIO))
			return MENOR_MEDIO;
		else
			return 0;
	}
	else
	{
		if ((valor < min) && (DirServo[RecNumServoRot(iNumServo)] < VALOR_MEDIO))
			return MAYOR_MEDIO;
		else if ((valor > max) && (DirServo[RecNumServoRot(iNumServo)] > VALOR_MEDIO))
			return MENOR_MEDIO;
		else
			return 0;
	}
}

static int ContadorFueraLimites = 0;

int ControlLimitesArticulacionesApagado()
{
	int ContadorFueraLimitesLocal = 0;
	for (int servo = 0; servo < NUM_SERVOS_ROT; servo++)
	{
		//Lee el valor de la posición del potenciómetros asociado al servo
		int valor = analogRead(pinPotenciometro(InfoServosRot[servo].NumServo));

		if (FueraDeRangos(InfoServosRot[servo].NumServo, valor, InfoServosRot[servo].Direccion, InfoServosRot[servo].MinPos - InfoServosRot[servo].Tolerancia* MULTIPLICADOR_TOLERANCIA_APAGADO, InfoServosRot[servo].MaxPos + InfoServosRot[servo].Tolerancia* MULTIPLICADOR_TOLERANCIA_APAGADO))
			ContadorFueraLimitesLocal++;
	}
	if (ContadorFueraLimitesLocal)
		ContadorFueraLimites++;
	else
		ContadorFueraLimites = 0;

	if (ContadorFueraLimites == MAX_CONTADOR_FUERA_LIMITES)
	{
		digitalWrite(PIN_ALIMENTACION_CUERPO, HIGH); //Apagamos cuerpo
		ContadorFueraLimites = 0;
	}
}



int ControlLimitesArticulaciones()
{
	for (int servo = 0; servo <= NUM_SERVOS_ROT; servo++)
	{
		//Lee el valor de la posición del potenciómetros asociado al servo
		int valor = analogRead(pinPotenciometro(InfoServosRot[servo].NumServo));

		if (FueraDeRangos(InfoServosRot[servo].NumServo, valor, InfoServosRot[servo].Direccion, InfoServosRot[servo].MinPos, InfoServosRot[servo].MaxPos))
			PararServo(InfoServosRot[servo].NumServo);
	}

	DebugInt(InfoServosRot[5].ValorPotenciometroParada, false);

}

int PararServo(int iNumServo)
{
	int iPos = InfoServosRot[RecNumServoRot(iNumServo)].PosParada;
	if (ServoRotacional(iNumServo))
		AsignarServo(iNumServo, iPos, GRADOS);
	return iPos;
}


void ControlPosicion()
{
	for (int servo = 0; servo <= NUM_SERVOS_ROT; servo++)
	{
		//Solo si no nos estamos movimiento por orden del interface de control podemos activar el reposicionamiento
		if (InfoServosRot[servo].Reposicionar != MOV_CONTROL)
		{ 
			//Recuperamos el valor del servo para comprobar si está parado
			int PosActualServo = InfoServosRot[servo].PosActual;
			int PosParadaArticulacion = InfoServosRot[servo].ValorPotenciometroParada;     //Recuperamos el valor del potenciómetro cuando se paró la última vez
			int PosActualArticulacion = analogRead(pinPotenciometro(InfoServosRot[servo].NumServo));    //Recuperamos el valor del potenciómetro ahora

			//Si no estamos parados, comprobamos si nos estamos reposicionando
			if (PosActualServo != InfoServosRot[servo].PosParada)
			{ //Solo controlamos la posición de la articulación si estamos parados

				//Si nos estamos reposicionando comprobamos si llegamos a la posición correcta de parada de nuevo
				if (InfoServosRot[servo].Reposicionar != SIN_ASIGNAR) //=> Nos estamos reposicionando
				{
					//Lee el valor de la posición del potenciómetros asociado al servo
					int valor = analogRead(pinPotenciometro(InfoServosRot[servo].NumServo));

					//Si estamos reposicionando y nos salimos de los límites paramos inmediatamente
					if (FueraDeRangos(InfoServosRot[servo].NumServo, valor, InfoServosRot[servo].Direccion, InfoServosRot[servo].MinPos, InfoServosRot[servo].MaxPos))
					{
						PararServo(InfoServosRot[servo].NumServo);
					}
					else //No estamos fuera de rango
					{
						//Si estamos reposicionando la articulación y alcanzamos la posición de parada, paramos el servo
						if ((InfoServosRot[servo].Reposicionar == ASCENDENTE) && (PosParadaArticulacion < PosActualArticulacion) ||
							((InfoServosRot[servo].Reposicionar == DESCENDENTE) && (PosParadaArticulacion > PosActualArticulacion)))
						{
							PararServo(InfoServosRot[servo].NumServo);
						}
					}
				}
			}
			else //Solo comprobamos el error en el punto de parada si estamos parados
			{
				//Comprobamos si la posición se sale de tolerancia, pero solo si no estamos reposicionando
				if (abs(PosParadaArticulacion - PosActualArticulacion) > InfoServosRot[servo].Tolerancia)
				{
					InfoServosRot[servo].NumVecesFueraTolerancia++;

					if (InfoServosRot[servo].NumVecesFueraTolerancia == NUM_VECES_FUERA_TOLERANCIA)
					{
						//DEBUGServo("C1", servo, PosParadaArticulacion, PosActualArticulacion);
						//DEBUGServo("C11", servo, PosActualServo, InfoServosRot[servo].PosParada);

						//Si estamos fuera de margen de parada activamos el reposicionamiento hasta recuperar la posición
						if (PosParadaArticulacion > PosActualArticulacion)
						{
							AsignarServo(InfoServosRot[servo].NumServo, (InfoServosRot[servo].Direccion == ASCENDENTE) ? SERVO_ROT_SUBIR : SERVO_ROT_BAJAR, GRADOS);
							InfoServosRot[servo].Reposicionar = ASCENDENTE;
							DEBUGServo("C12", servo, InfoServosRot[servo].PosActual, InfoServosRot[servo].PosParada);
						}
						else
						{
							AsignarServo(InfoServosRot[servo].NumServo, (InfoServosRot[servo].Direccion == ASCENDENTE) ? SERVO_ROT_BAJAR : SERVO_ROT_SUBIR, GRADOS);
							InfoServosRot[servo].Reposicionar = DESCENDENTE;
							DEBUGServo("C13", servo, InfoServosRot[servo].PosActual, InfoServosRot[servo].PosParada);
						}
					}
				}
				else
					InfoServosRot[servo].NumVecesFueraTolerancia = 0;
			}
		}
	}
} 

void EnviarEstadoMotoresServosRot()
{
	for (int i = 0; i < NUM_SERVOS_ROT; i++)
	{
		if (i != 0) Serial.print(",");
		Serial.print(InfoServosRot[i].PosActual);
	}
}


void DEBUGServo(String sCodigo, int iServo, int iValor1, int iValor2)
{
	return;
	Serial.print("DBG_" + sCodigo);
	Serial.print("->");
	Serial.print(iServo);
	Serial.print("->");
	Serial.print(iValor1);
	Serial.print(",");
	Serial.println(iValor2);
}

void DEBUGprint(String Cad, int p1, int p2, int p3)
{
	Serial.print("DBG_" + Cad);
	Serial.print("->");
	Serial.print(p1);
	Serial.print(", ");
	Serial.print(p2);
	Serial.print(", ");
	Serial.println(p3);
}
void EstablecerMovimientoServoRot(int iNumServo, int iValorPot, int iPorcPotencia)
{
	int iValorInicial =
			InfoServosRot[RecNumServoRot(iNumServo)].ValorPotInicial = analogRead(pinPotenciometro(iNumServo));
	InfoServosRot[RecNumServoRot(iNumServo)].ValorPotFinal = iValorPot;
	InfoServosRot[RecNumServoRot(iNumServo)].PorcentajePotencia = iPorcPotencia;
	InfoServosRot[RecNumServoRot(iNumServo)].MovimientoActivo = true;

	int iPotencia = 0;

	bool bPotAlta =  (iValorPot < iValorInicial);
	bPotAlta = (InfoServosRot[RecNumServoRot(iNumServo)].Direccion == ASCENDENTE ? bPotAlta: !bPotAlta);

	if (bPotAlta)
		iPotencia = InfoServosRot[RecNumServoRot(iNumServo)].PosParada +
			(179 - InfoServosRot[RecNumServoRot(iNumServo)].PosParada)*iPorcPotencia/100;
	else
		iPotencia = InfoServosRot[RecNumServoRot(iNumServo)].PosParada -
			InfoServosRot[RecNumServoRot(iNumServo)].PosParada*iPorcPotencia/100;

	AsignarServo(iNumServo, iPotencia, GRADOS);
}

void ControlPosicionamientoServosRot()
{
	for (int i = 18; i <= 24; i++)
	{
		if (i==21) continue;

		if (InfoServosRot[RecNumServoRot(i)].MovimientoActivo)
		{
			int iValorPotActual = analogRead(pinPotenciometro(i));
			bool Ascendente = (InfoServosRot[RecNumServoRot(i)].ValorPotInicial < InfoServosRot[RecNumServoRot(i)].ValorPotFinal);
			bool ValorSuperado = (iValorPotActual >= InfoServosRot[RecNumServoRot(i)].ValorPotFinal);
			if ((Ascendente && ValorSuperado) || (!Ascendente && !ValorSuperado))
			{
				InfoServosRot[RecNumServoRot(i)].MovimientoActivo = false;
				PararServo(i);
			}
		}
	}
}

void ControlMovimientoTemporizado()
{
	long ms = millis();
	  for (int i = 2; i <= 16; i++)
	  {
		  int indServo = RecNumServo(i);
		  if (aPosServos[indServo].MovTemporizadoActivo)
		  {
			  if (ms > aPosServos[indServo].ms_final)
			  {
				  AsignarServo(i, aPosServos[indServo].iValorFinTemporizado, GRADOS);
				  aPosServos[indServo].MovTemporizadoActivo = false;
				  aPosServos[indServo].ms_tiempo_mov = 0;
			  }
			  else
			  {
				  float Avance = 1 - float(abs((aPosServos[indServo].ms_final-ms))) / (aPosServos[indServo].ms_final-aPosServos[indServo].ms_inicial);
				  int iValor = aPosServos[indServo].iValoIniTemporizado + 1.0*(aPosServos[indServo].iValorFinTemporizado-aPosServos[indServo].iValoIniTemporizado)*Avance;

				  if (iValor != aPosServos[indServo].iValor)
					  AsignarServo(i, iValor, GRADOS);
			  }
		  }
	  }
}
