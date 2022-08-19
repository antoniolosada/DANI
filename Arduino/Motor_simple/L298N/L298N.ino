
int IN3 = 5;
int IN4 = 4;
int INB = 3;

void setup() {
  // put your setup code here, to run once:

  pinMode(IN3, OUTPUT);
  pinMode(IN4, OUTPUT);
  pinMode(INB, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly: 
  digitalWrite(IN3, HIGH);
  digitalWrite(IN4, LOW);
  analogWrite(INB, 55);
  delay(2000);
  analogWrite(INB, 155);
  delay(2000);
  analogWrite(INB, 255);
  delay(2000);

  analogWrite(INB, 0);
  delay(2000);

  digitalWrite(IN3, LOW);
  digitalWrite(IN4, HIGH);
  analogWrite(INB, 55);
  delay(2000);
  analogWrite(INB, 155);
  delay(2000);
  analogWrite(INB, 255);
  delay(2000);

  analogWrite(INB, 0);
  delay(2000);
  
}
