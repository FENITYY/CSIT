int a0 = 0;
int led1 = 4;
int led2 = 2;
int led3 = 3;

void setup()
{
    pinMode(A0, INPUT);
    pinMode(led1, OUTPUT);
    pinMode(led2, OUTPUT);
    pinMode(led3, OUTPUT);
    Serial.begin(9600);
}

void loop()
{
    a0 = analogRead(A0);
    Serial.println(a0);
    delay(10);

    if (a0 <= 400){
        digitalWrite(led1, HIGH);
        digitalWrite(led2, LOW);
        digitalWrite(led3, LOW);
    }

    else if (a0 <= 600){
        digitalWrite(led2, HIGH);
        digitalWrite(led1, LOW);
        digitalWrite(led3, LOW);
    }

    else{
        digitalWrite(led3, HIGH);
        digitalWrite(led1, LOW);
        digitalWrite(led2, LOW);
    }
}