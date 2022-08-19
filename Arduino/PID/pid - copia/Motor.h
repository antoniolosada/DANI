class Motor
{
  #define MOTOR1  0
  #define MOTOR2  1
  
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

