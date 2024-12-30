//Pin Assignment
int pinG = 9;
int pinB = 10;
int pinR = 11;

//RGB as strings
char RedValue[4];
char GreenValue[4];
char BlueValue[4];
char RGBValues[10];

void setup() {
  Serial.begin(9600);
  pinMode(pinG, OUTPUT);
  pinMode(pinB, OUTPUT);
  pinMode(pinR, OUTPUT);
}

void setRGBValues(int r, int g, int b) {
  analogWrite(pinR, r);
  analogWrite(pinG, g);
  analogWrite(pinB, b);
  delay(40);
}

void collectRGBValues() {
  // Extract Red value
  for (int i = 0; i < 3; i++) {
    RedValue[i] = RGBValues[i];
  }
  RedValue[3] = '\0';

  // Extract Green value
  for (int i = 3; i < 6; i++) {
    GreenValue[i - 3] = RGBValues[i];
  }
  GreenValue[3] = '\0';

  // Extract Blue value
  for (int i = 6; i < 9; i++) {
    BlueValue[i - 6] = RGBValues[i];
  }
  BlueValue[3] = '\0';
}

void loop() {
  if (Serial.available() > 0) {
    String inputRGB = Serial.readStringUntil('\n');  // Read input string
    inputRGB.trim();

    // VID Format
    if (inputRGB.length() == 9) {
      inputRGB.toCharArray(RGBValues, 10);
      collectRGBValues();
      setRGBValues(atoi(RedValue), atoi(GreenValue), atoi(BlueValue));  // Convert and set RGB
    } else {
      Serial.println("Invalid input! Enter a 9-character string like 255255255.");
    }
  }
}