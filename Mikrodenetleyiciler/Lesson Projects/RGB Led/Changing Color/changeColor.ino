int R = 5, B = 3, G = 6;

void setup()
{
    pinMode(R, OUTPUT);
    pinMode(G, OUTPUT);
    pinMode(B, OUTPUT);
}

void loop()
{
  // White
    analogWrite(R, 255);analogWrite(G, 255);analogWrite(B, 255);
    delay(1000);

  // Yellow
    analogWrite(R, 255);analogWrite(G, 255);analogWrite(B, 0);
    delay(1000);

  // Purple
    analogWrite(R, 255);analogWrite(G, 0);analogWrite(B, 255);
    delay(1000);

  // Red
    analogWrite(R, 255);analogWrite(G, 0);analogWrite(B, 0);
    delay(1000);
}