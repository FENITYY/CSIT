// Gerekli kütüphanelerin tanımlanması
#include <Wire.h> // LCD için haberleşmeyi sağlayan I2C protokolü için gerekli kütüphane 
#include <Adafruit_LiquidCrystal.h> // Devrede kullanılan LCD'nin kullanımı için gerekli kütüphane

// Durum Sıraları Tanımlanması
const int POMODORO = 0;
const int SHORT_BREAK = 1;
const int LONG_BREAK = 2;

// Durum Sürelerinin Tanımlanması
const int POMODORO_DURATION = 25 * 60;
const int SHORT_BREAK_DURATION = 5 * 60;
const int LONG_BREAK_DURATION = 15 * 60;

// Arduino Pin Girişlerinin Tanımlanması
const int buzzerPin = 2;
const int potentiometerPin = A0;
Adafruit_LiquidCrystal lcd_1(0); 

// Başlangıç Durumunun Belirlenmesi
int currentState = POMODORO;
long seconds = 0;
bool timerRunning = false;
int pomodoroCount = 0; // Pomodoro sayısını tutan değişken

void setup() {
  lcd_1.begin(16, 2);
  pinMode(buzzerPin, OUTPUT);
}

void loop() {
  lcd_1.setCursor(0, 0);
  lcd_1.print("                ");
  lcd_1.setCursor(0, 1);
  lcd_1.print("                ");

  lcd_1.setCursor(0, 0);

  switch (currentState) {
    case POMODORO:
      lcd_1.print("Pomodoro");
      break;
    case SHORT_BREAK:
      lcd_1.print("Kısa Mola");
      break;
    case LONG_BREAK:
      lcd_1.print("Uzun Mola");
      break;
  }

  lcd_1.setCursor(0, 1);
  lcd_1.print(formatTime(seconds));

  int potValue = analogRead(potentiometerPin);
  int potThreshold = 500;

  if (potValue > potThreshold) {
    delay(50);
    timerRunning = !timerRunning;

    if (timerRunning) {
      digitalWrite(buzzerPin, HIGH);
      delay(50);
      digitalWrite(buzzerPin, LOW);
    }

    while (analogRead(potentiometerPin) > potThreshold) {
      delay(10);
    }
  }

  if (timerRunning) {
    delay(1000);

    if (seconds >= getStateDuration(currentState)) {
      seconds = 0;
      switchState();
    }

    seconds += 1;
  }
}

// Durum Süresini Almak İçin Fonksiyon
int getStateDuration(int state) {
  switch (state) {
    case POMODORO:
      return POMODORO_DURATION;
    case SHORT_BREAK:
      return SHORT_BREAK_DURATION;
    case LONG_BREAK:
      return LONG_BREAK_DURATION;
  }
  return 0;
}

// Durumu Değiştirmek İçin Fonksiyon
void switchState() {
  digitalWrite(buzzerPin, HIGH);
  delay(500);
  digitalWrite(buzzerPin, LOW);

  switch (currentState) {
    case POMODORO:
      pomodoroCount++;
      if (pomodoroCount < 4) {
        currentState = SHORT_BREAK;
      } else {
        currentState = LONG_BREAK;
        pomodoroCount = 0; // 4 Pomodoro sonrası Long Break başlar, Pomodoro sayısı sıfırlanır.
      }
      break;
    case SHORT_BREAK:
      currentState = POMODORO;
      break;
    case LONG_BREAK:
      currentState = POMODORO;
      break;
  }
}

// Zamanı Biçimlendirmek İçin Fonksiyon
String formatTime(long seconds) {
  int minutes = seconds / 60;
  int remainingSeconds = seconds % 60;
  return String(minutes) + "m " + String(remainingSeconds) + "s";
}