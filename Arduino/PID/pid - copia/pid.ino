
#include <PID_v1.h>
#include <Encoder.h>

#define MOTOR_D  0
#define MOTOR_I  1

class Motor
{
  byte IN1;
  byte IN2;
  byte ENA;
  byte IN3;
  byte IN4;
  byte ENB;
  
  public:
    Motor(int in1, int in2, int ina);
    void Avanzar(int velocidad);
    void Retroceder(int velocidad);
};

class Encoder
{
  public:
  long tiempo_revolucion;
  long tiempo_revolucion_anterior;
  long tiempo_marca;
  byte contador_marcas;

  float rev_min;

  void Inicializar();
  void CalcularRPM();
  void ComprobarRPM_0();
  long TiempoTranscurrido(long TiempoActual, long TiempoAnterior);
};



Motor motord(6,7,5);
Motor motori(8,9,10);
Encoder rpm[2];

//Define Variables we'll be connecting to
double Setpoint_d, Input_d, Output_d;
double Setpoint_i, Input_i, Output_i;

//Specify the links and initial tuning parameters
PID myPIDd(&Input_d, &Output_d, &Setpoint_d ,2,5,1, DIRECT);
PID myPIDi(&Input_i, &Output_i, &Setpoint_i ,2,5,1, DIRECT);


void setup() {
  
  rpm[0].Inicializar();
  rpm[1].Inicializar();
  
  pinMode(2, INPUT);
  pinMode(3, INPUT);
  
  attachInterrupt(0, inter_pin2, RISING);
  attachInterrupt(1, inter_pin3, RISING);
  
  Serial.begin(9600);

  Setpoint_d = 80;
  Setpoint_i = 80;
  myPIDd.SetMode(AUTOMATIC);
  myPIDd.SetSampleTime(100);
  myPIDd.SetOutputLimits(0, 255);

  myPIDi.SetMode(AUTOMATIC);
  myPIDi.SetSampleTime(100);
  myPIDi.SetOutputLimits(0, 255);

  Serial.print("Inicio");
}

void loop() 
{
  Input_d = rpm[MOTOR_D].rev_min;
  myPIDd.Compute();
  motord.Avanzar(Output_d);

  Input_i = rpm[MOTOR_I].rev_min;
  myPIDi.Compute();
  motori.Avanzar(Output_i);
  
  Serial.print(rpm[MOTOR_D].rev_min);
  Serial.print(", ");
  Serial.print(rpm[MOTOR_I].rev_min);
  Serial.print("-> ");
  Serial.print(Output_d);
  Serial.print(", ");
  Serial.print(Output_i);
 
  Serial.println("");
}



void inter_pin2()
{
  rpm[MOTOR_I].CalcularRPM();
}

void inter_pin3()
{
  rpm[MOTOR_D].CalcularRPM();
}
