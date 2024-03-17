int led=3;

void setup() {
    pinMode(led, OUTPUT);
}

void loop() {
    int ldrValue = analogRead(A0);
    Serial.println(ldrValue);
    
    if (ldrValue <= 250){
        digitalWrite(led, HIGH);
    }
    else {
        digitalWrite(led, LOW);
    }
    
    delay(500);
}