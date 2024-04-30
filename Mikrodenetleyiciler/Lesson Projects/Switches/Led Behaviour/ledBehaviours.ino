// C++ code
//

int switchLeft = 2;
int switchRight = 3;
int led1 = 4;
int led2 = 5;
int led3 = 6;

void setup()
{
    pinMode(switchLeft, INPUT);
    pinMode(switchRight, INPUT);
    pinMode(led1, OUTPUT);
    pinMode(led2, OUTPUT);
    pinMode(led3, OUTPUT);
}

void loop()
{
    if (digitalRead(switchLeft) == true){
        digitalWrite(led1, HIGH);
        digitalWrite(led2, HIGH);
        digitalWrite(led3, HIGH);
}

    else if (digitalRead(switchRight == true)){
        digitalWrite(led1, HIGH);
        digitalWrite(led2, HIGH);
        digitalWrite(led3, HIGH);
        delay(500);
        digitalWrite(led1, LOW);
        digitalWrite(led2, LOW);
        digitalWrite(led3, LOW);
        delay(500);
    }
}