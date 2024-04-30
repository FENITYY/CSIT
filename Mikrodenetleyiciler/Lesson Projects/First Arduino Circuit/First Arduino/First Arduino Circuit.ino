// Led order is from right to left!!!

void setup() {
  // put your setup code here, to run once:
  pinMode(1, OUTPUT);
  pinMode(2, OUTPUT);
  pinMode(3, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(5, OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  
  // First Step (1 - 3 - 5)
  digitalWrite(1, HIGH);
  digitalWrite(3, HIGH);
  digitalWrite(5, HIGH);
  delay(500);
  
  // Second Step (1 - 2 - 3 - 4 - 5)
  digitalWrite(2, HIGH);
  digitalWrite(4, HIGH);
  delay(500);

  // Third Step (3 - 4 - 5)
  digitalWrite(1, LOW);
  digitalWrite(2, LOW);
  digitalWrite(3, HIGH);
  digitalWrite(5, HIGH);
  delay(500);

  // Close All Open Leds
  digitalWrite(3, LOW);
  digitalWrite(4, LOW);
  digitalWrite(5, LOW);
  delay(500);
}
