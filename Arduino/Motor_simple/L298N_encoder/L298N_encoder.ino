
int INA = 5;
int IN1 = 6;
int IN2 = 7;
int IN3 = 8;
int IN4 = 9;
int INB = 10;

int contador = 0;
int contadord = 0;

void setup() {
  // put your setup code here, to run once:

  pinMode(IN1, OUTPUT);
  pinMode(IN2, OUTPUT);
  pinMode(INA, OUTPUT);

  pinMode(IN3, OUTPUT);
  pinMode(IN4, OUTPUT);
  pinMode(INB, OUTPUT);
  
  pinMode(2, INPUT);
  pinMode(3, INPUT);
  
  attachInterrupt(0, inter, RISING);
  attachInterrupt(1, interd, RISING);
  
  Serial.begin(9600);

  // put your main code here, to run repeatedly: 


  analogWrite(INA, 0);
  analogWrite(INB, 0);
}

void loop() {
   return;
  for (int i = 0; i< 10; i++)
  {
    Serial.print(contador);
    Serial.print(", ");
    Serial.print(contadord);
    Serial.print(", ");
    Serial.print(analogRead(4));
    Serial.println("");
    delay(50);
  }
  
  
  digitalWrite(IN1, HIGH);
  digitalWrite(IN2, LOW);
  digitalWrite(IN3, HIGH);
  digitalWrite(IN4, LOW);
  analogWrite(INB, 155);
  analogWrite(INA, 155);
  delay(2000);
  analogWrite(INB, 255);
  analogWrite(INA, 255);
  delay(2000);

  analogWrite(INB, 0);
  analogWrite(INA, 0);
  delay(2000);

  digitalWrite(IN1, LOW);
  digitalWrite(IN2, HIGH);
  digitalWrite(IN3, LOW);
  digitalWrite(IN4, HIGH);
  analogWrite(INA, 95);
  analogWrite(INB, 95);
  delay(2000);
  analogWrite(INB, 155);
  analogWrite(INA, 155);
  delay(2000);
  analogWrite(INB, 255);
  analogWrite(INA, 255);
  delay(2000);

  analogWrite(INB, 0);
  analogWrite(INA, 0);
  delay(2000);
  
}



void inter()
{
  contador++;
}
void interd()
{
  contadord++;
}
