int redLed = 1, greenLed = 2;
int celsius = 21, nem = 40;

void setup() {
  // put your setup code here, to run once:
    pinMode(redLed, OUTPUT);
    pinMode(greenLed, OUTPUT);
}

void loop() {
    if (celsius <= 21 && nem > 50){
        digitalWrite(greenLed, HIGH);
        digitalWrite(redLed, LOW);
    }
    else{
        digitalWrite(greenLed, LOW);
        digitalWrite(redLed, HIGH);
    }
}