void setup() {
    Serial.begin(9600);
}

void loop() {
    for (int i = 0; i < 10000; i++){
        Serial.println(i);
        delay(100);
    }
}