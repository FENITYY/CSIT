int LEDs[] = {2, 3, 4, 5, 6, 7};

void setup() {
    for (int i = 0; i < 6; i++){
        pinMode(LEDs[i], OUTPUT);
    }
}

void loop() {
    for (int i = 0; i < 6; i++){
        digitalWrite(LEDs[i], HIGH);
        delay(50);
        digitalWrite(LEDs[i], LOW);
    }

    for (int j = 5; j > -1; j--){
    digitalWrite(LEDs[j], HIGH);
    delay(50);
    digitalWrite(LEDs[j], LOW);
    }
}