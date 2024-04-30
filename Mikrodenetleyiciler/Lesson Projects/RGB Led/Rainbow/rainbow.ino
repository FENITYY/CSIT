int r = 2, g = 4, b = 3;

void setup(){
	pinMode(r, OUTPUT);
    pinMode(g, OUTPUT);
    pinMode(b, OUTPUT);
}

void loop(){
	digitalWrite(r, LOW);
    digitalWrite(g, HIGH);
    delay(150);

    digitalWrite(g, LOW);
    digitalWrite(b, HIGH);
    delay(150);

    digitalWrite(b, LOW);
    digitalWrite(r, HIGH);
    delay(150);
}