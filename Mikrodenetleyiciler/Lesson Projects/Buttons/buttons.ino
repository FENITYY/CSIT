// C++ code
//

int led1 = 2;
int led2 = 3;
int led3 = 4;
int led4 = 5;
int button = 6;

void setup()
{
    pinMode(led1, OUTPUT);
    pinMode(led2, OUTPUT);
    pinMode(led3, OUTPUT);
    pinMode(led4, OUTPUT);
    pinMode(button, INPUT);
}

void loop()
{
    if (digitalRead(button) == HIGH){
        digitalWrite(led1, HIGH);
        delay(500);
        digitalWrite(led2, HIGH);
        delay(500);
        digitalWrite(led3, HIGH);
        delay(500);
        digitalWrite(led4, HIGH);
        delay(500);
    }
}