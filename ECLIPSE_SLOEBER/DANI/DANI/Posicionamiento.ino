#define MIN_SERVO_POS   16
#define MAX_SERVO_POS	25

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
	direccion = 26,
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
   {hombro_cuerpo_derecho,ASCENDENTE, 108,844,970,10,0,0,0},
   {hombro_brazo_derecho,ASCENDENTE, 109,300,580,20,0,0,0},
   {biceps_derecho,ASCENDENTE, 70,140,560,10,0,0,0},
   {hombro_cuerpo_iquierdo,DESCENDENTE, 80,555,748,10,0,0,0},
   {hombro_brazo_iquierdo,ASCENDENTE, 78,510,719,10,0,0,0},
   {biceps_izquierdo,ASCENDENTE, 75,359,547,10,0,0,0} };


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
  {direccion, 85, 1, 170}
};



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
    case 2: return 22; //pulgar
    case 3: return 23; //Incide 167-33
    case 4: return 24; //Corazón 159-55
    case 5: return 25; //Anular 178-57
    case 6: return 29; //Meñique
    case 7: return 28; //Giro Muñeca

    case 8: return 46; //pulgar
    case 9: return 47; //indice
    case 10: return 48; //medio
    case 11: return 51; //anular
    case 12: return 52; //Meñique
    case 13: return 53; //muñeca

    case 14: return 31; //boca
    case 15: return 32; //Mivimiento lateral cabeza
    case 16: return 33; //Subir-Bajar cabeza

	//Servos rotacionales
    case 18: return 45; //Hombro-cuerpo der
    case 19: return 42; //Hombro-brazo der
    case 20: return 43; //Codo der
    case 22: return 35; //Hombro-cuerpo izq
    case 23: return 37; //Hombro-Brazo izq
    case 24: return 36; //Biceps izq

	case 26: return 8; //Servo dirección - blanco
  }
  return 0;  
  
}

//Pin de los potenciómetros de cada articulación
int pinPotenciometro(int iNumServo)
{
  switch (iNumServo)
  {
	case 18: return 13; //hombro-brazo der
	case 19: return 12; //Hombro-brazo der
    case 20: return 15; //codo der

    case 22: return 9; //hombro-brazo der
    case 23: return 11; //hombro-brazo der
    case 24: return 8; //hombro-brazo der
  }
}

bool ServoRotacional(int ns)
{
	if ((ns >= 18) && (ns <= 24) && (ns != 21))
		return true;
	else
		return false;
}

//Establecer como posición inicial la posición actual (Arduino)
void PosicionInicial()
{
	ControlPosicionActivo = false;
	//Servos rotacionales
	for (int i = 0; i < NUM_SERVOS_ROT; i++)
	{
		AsignarServo(InfoServosRot[i].NumServo, InfoServosRot[i].PosParada, GRADOS);
		InfoServosRot[i].PosActual = InfoServosRot[i].PosParada;
		InfoServosRot[i].ValorPotenciometroParada = analogRead(pinPotenciometro(InfoServosRot[i].NumServo));
		InfoServosRot[i].Reposicionar = SIN_ASIGNAR;
	}

	//Servos normales
	for (int i = 0; i < NUM_SERVOS; i++)
		AsignarServo(InfoServos[i].NumServo, InfoServos[i].PosInicial, GRADOS);
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
		InfoServosRot[RecNumServoRot(iNumServo)].NumVecesFueraTolerancia = 0;
		InfoServosRot[RecNumServoRot(iNumServo)].ValorPotenciometroParada = analogRead(pinPotenciometro(iNumServo));
		DirServo[RecNumServoRot(iNumServo)] = iValor;

		if (EstamosParandoServoRot(iNumServo, iValor))
			InfoServosRot[RecNumServoRot(iNumServo)].Reposicionar = SIN_ASIGNAR; //Permitimos que se active el reposicionamiento
		else
			InfoServosRot[RecNumServoRot(iNumServo)].Reposicionar = MOV_CONTROL; //Estamos en movimiento y no se puede activar el reposicionamiento
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

//Asignación de valor de servo tanto desde controles internos como desde interface de control
void AsignarServo(int iNumServo, int iValor, int iUnidad)
{
  int iMin, iMax;
  
  iMin = 0;
  iMax = 179;

   if ((iUnidad == GRADOS) && (iNumServo >= 2) && (iNumServo <= 26))
   {
	   //Si es un servo normal sobreescribimos los límites
	   if (!ServoRotacional(iNumServo))
	   {
		   iMin = InfoServos[RecNumServo(iNumServo)].MinPos;
		   iMax = InfoServos[RecNumServo(iNumServo)].MaxPos;
	   }

	   //Asignamos el valor a los servos
       if ((iValor >= iMin) && (iValor <= iMax))
		aServo[RecNumServo(iNumServo)].write(iValor);

	   //Grabamos el último valor asignado
	   aPosServos[RecNumServo(iNumServo)].iValor = iValor;
       aPosServos[RecNumServo(iNumServo)].iUnidad = iUnidad;

	   if (ServoRotacional(iNumServo))
	   {
		   InfoServosRot[RecNumServoRot(iNumServo)].PosActual = iValor;
		   if (EstamosParandoServoRot(iNumServo, iValor))
		   {
			   InfoServosRot[RecNumServoRot(iNumServo)].Reposicionar = SIN_ASIGNAR;
			   InfoServosRot[RecNumServoRot(iNumServo)].NumVecesFueraTolerancia = 0;
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
