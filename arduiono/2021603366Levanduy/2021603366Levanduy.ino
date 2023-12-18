bool enable = false;
void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);
  pinMode(13, OUTPUT);
}
void check(){
  if(enable){
    Serial.println(analogRead(A1));
    if(analogRead(A1) > 700){
      digitalWrite(13, HIGH);
    } else {
      digitalWrite(13, LOW);
    }
  } else {
    digitalWrite(13, LOW);
  }
}

void loop() {
  // put your main code here, to run repeatedly:
  while(Serial.available() > 0){
    char command = Serial.read();
    if(command == 'o') enable = true;
    if(command == 'n') enable = false;
  }
  check();
}
