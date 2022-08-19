// Sweep
// by BARRAGAN <http://barraganstudio.com> 
// This example code is in the public domain.

//Pos central servo1 108
//Pos central servo2 95
//Pos central servo3 80

//Cable verde
// Terminal verde -> negativo de la placa de control de movimiento
// Terminal blanco -> M
// Terminal azul -> D
// Terminal amarillo -> S
#include <Servo.h> 
int option;
int led = 13;
int PIN_MOTOR = 10;
 
Servo myservo;  // create servo object to control a servo 
                // a maximum of eight servo objects can be created 
Servo myservo1;                
Servo myservo2;
 
int pos = 0;    // variable to store the servo position 
 
void setup() 
{ 
  Serial.begin(57600);
  pinMode(led, OUTPUT); 
  myservo.attach(45);  // attaches the servo on pin 9 to the servo object 
  myservo1.attach(4);  // attaches the servo on pin 9 to the servo object 
  pinMode(44, OUTPUT);
  pinMode(43, OUTPUT);
  pinMode(10, OUTPUT);
  
  myservo2.attach(32);  // attaches the servo on pin 9 to the servo object 
  pinMode(21, OUTPUT);
} 
 
 
void loop() 
{ 
  //-------------
  int i = 2;
  //-------------
  
  int j, c;

if (i == 2)
{  
  digitalWrite(21, 0);
  for (j = 70; j <= 84; j++)
  {
    myservo2.write(j);
    delay(10);
  }
  for (j = 84; j >= 70; j--)
  {
    myservo2.write(j);
    delay(10);
  }
}
else
if (i ==0)
{  
    while (Serial.available() > 0) {
      int d = Serial.parseInt(); 
          myservo.write(d);
          Serial.println(d);
      }
}
else
{
  
  j = analogRead(0);
  c++;
  
  if (c == 30000) c = 0;
  
  //if (c%10000 == 0)  Serial.println(j);
  
  //si existe datos disponibles los leemos
  if (Serial.available()>0){
    //leemos la opcion enviada
    option=Serial.read();
  
  
    if(option=='d') {
      myservo.write(180);              // Movimiento a la derecha
      digitalWrite(led, LOW);
      Serial.println("DERECHA");
    }
    if(option=='i') {
      myservo.write(10);              // Movimiento a la izquierda
      digitalWrite(led, HIGH);
      Serial.println("IZQUIERDA");
    }
    if(option=='p') {
      myservo.write(80);              // Parada
      digitalWrite(led, HIGH);
      Serial.println("PARAR");
    }

    if(option=='D') {
      myservo1.write(180);              // Movimiento a la derecha
      digitalWrite(led, LOW);
      Serial.println("DERECHA");
    }
    if(option=='I') {
      myservo1.write(10);              // Movimiento a la izquierda
      digitalWrite(led, HIGH);
      Serial.println("IZQUIERDA");
    }
    if(option=='P') {
      myservo1.write(90);              // Parada
      digitalWrite(led, HIGH);
      Serial.println("PARAR");
    }

    if(option=='1') {
        digitalWrite(44,HIGH);
    }

    if(option=='0') {
        digitalWrite(44,LOW);
    }
    if(option=='3') {
        analogWrite(44,250);
    }

    if(option=='2') {
        analogWrite(43,0);
    }

    if(option=='3') {
        analogWrite(43,120);
    }
    if(option=='4') {
        analogWrite(43,250);
    }
    
    
    if(option=='5') {
        analogWrite(PIN_MOTOR,60);
      Serial.println("MOTOR 5");
    }
    if(option=='6') {
        analogWrite(PIN_MOTOR,120);
      Serial.println("MOTOR 6");
    }
    if(option=='7') {
        analogWrite(PIN_MOTOR,180);
      Serial.println("MOTOR 7");
    }
    if(option=='8') {
        analogWrite(PIN_MOTOR,240);
      Serial.println("MOTOR 8");
    }


    if(option=='b') {
      //servo boca reposo
      myservo.write(100);              // tell servo to go to position in variable 'pos' 
      digitalWrite(led, HIGH);
      Serial.println("SERVO BOCA POS REPOSO");
    }
  }
}
} 
