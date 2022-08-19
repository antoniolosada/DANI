#include <Motor.h>

Motor::Motor(int in1, int in2, int ina)
{
  IN1 = in1;
  IN2 = in2;
  
  ENA = ina;
  //Inicializamos los motores
  pinMode(IN1, OUTPUT);
  pinMode(IN2, OUTPUT);
  pinMode(ENA, OUTPUT);
}
    
void Motor::Avanzar(int velocidad)
{
  digitalWrite(IN1, HIGH);
  digitalWrite(IN2, LOW);
  analogWrite(ENA, velocidad);
}

void Motor::Retroceder(int velocidad)
{
  digitalWrite(IN1, LOW);
  digitalWrite(IN2, HIGH);
  analogWrite(ENA, velocidad);
}

