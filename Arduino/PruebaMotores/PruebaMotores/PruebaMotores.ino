
#define PIN_ALIMENTACION_BASE      20
// 9 motor 10 pwm

void setup() {
  // put your setup code here, to run once:
  pinMode(9, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(PIN_ALIMENTACION_BASE, OUTPUT);

  digitalWrite(PIN_ALIMENTACION_BASE, LOW);
  digitalWrite(9, HIGH);
}

void loop() {
  // put your main code here, to run repeatedly: 

  analogWrite(10, 80);
  delay(2000);
  analogWrite(10, 200);
  delay(2000);
}
