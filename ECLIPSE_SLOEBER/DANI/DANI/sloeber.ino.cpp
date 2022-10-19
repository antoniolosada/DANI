#ifdef __IN_ECLIPSE__
//This is a automatic generated file
//Please do not modify this file
//If you touch this file your change will be overwritten during the next build
//This file has been generated on 2022-10-17 19:30:47

#include "Arduino.h"
#include "pines.h"
#include <Arduino.h>
#include <ServoTimer2.h>
#define Servo ServoTimer2
#include <RF24.h>
#include <RF24_config.h>
#include <VirtualWire.h>
#include "pines.h"
#include "list.h"
#include "node_cpp.h"
#include "list.cpp"
#include "node_cpp.cpp"
#include "SAPPO.h"

int ComprobarCRC(int CRC, char *cad) ;
int LeerCadena(int *i, char *Cadena) ;
void ProcesarCadena(char *Cadena) ;
void EnviarEstadoEncendidoCfg() ;
void EnviarEstadoEncendidoReles() ;
void EnviarDistancias() ;
void EnviarArticulaciones() ;
void EnviarSensorLinea() ;
void EnviarContadorMarcasRueda() ;
int RecValor(char *Cadena, int iPosIni, char cDelimitador, int *iFinPos) ;
char * RecCadena(char *Cadena, int iPosIni, char cDelimitador, int *iFinPos) ;
void ApagadoMotorProgresivo() ;
void setup()  ;
void loop()  ;
void ControlDesconexionServos() ;
void MovimientoTemporizado() ;
void MedirDistanciaSensor3() ;
void ComprobarControlColision() ;
void ContadorVelocidad() ;
void DistanciaD() ;
void DistanciaC() ;
void DistanciaI() ;
void DistanciaT() ;
void MedirDistancia(byte sensord) ;
int CargarSecuencia() ;
int EjecutarSecuencia() ;
void LOG2int(char *c1, int i2) ;
void LOG2(char *c1, char *c2) ;
void LOG3(char *c1, char *c2, char *c3) ;
void LOG_DEBUG(char *c1, long l1, long l2, float l3, float l4) ;
void ControlLimites() ;
void PruebaMovimientoCabeza() ;
void DebugInt(int valor, bool concatenar) ;
void DebugChar(char valor, bool concatenar) ;
void DebugCadena(String valor, bool concatenar) ;
int freeRam() ;
byte RecNumServoRot(int servo) ;
byte RecNumServo(int servo) ;
int LeerPosicionArticulacion(int ns) ;
int pin(int iNumServo) ;
int pinPotenciometro(int iNumServo) ;
bool ServoRotacional(int ns) ;
void PosicionInicial() ;
void ActivarCabeza() ;
void ActivarBase() ;
void ActivarCuerpo() ;
void GrabarValorParada(int iNumServo, int iValor) ;
bool EstamosParandoServoRot(int iNumServo, int iValor) ;
void AsignarServoControl(int iNumServo, int iValor, int iModo) ;
void CambiarPosicionParada(int iNumServo, int iPos)  ;
void CambiarValorServoParada(int iNumServo, int iPos)  ;
unsigned long TiempoDesconexion(int iValorActual, int iValorNuevo, bool ServoRotContinua) ;
void AsignarServo(int iNumServo, int iValor, int iUnidad) ;
int FueraDeRangos(int iNumServo, int valor, int dir, int min, int max) ;
int ControlLimitesArticulacionesApagado() ;
int ControlLimitesArticulaciones() ;
int PararServo(int iNumServo) ;
void ControlPosicion() ;
void EnviarEstadoMotoresServosRot() ;
void DEBUGServo(String sCodigo, int iServo, int iValor1, int iValor2) ;
void DEBUGprint(String Cad, int p1, int p2, int p3) ;
void EstablecerMovimientoServoRot(int iNumServo, int iValorPot, int iPorcPotencia) ;
void ControlPosicionamientoServosRot() ;
void ControlMovimientoTemporizado() ;

#include "DANI.ino"

#include "ComSerie.ino"
#include "Posicionamiento.ino"

#endif
