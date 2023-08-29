// variable to receive data from serial port
int inByte=0;
int startByte=88;
int stopByte=89;
int plusByte=43;

// Pin 13 adalah LED bawaan pada Arduino.
int led = 13;
const int Start = 2;
const int Stop =3;
const int Plus =4;
int mulai=0;
int berhenti=0;
int plus=0;
//ASCII 128 

// 65=A , 66=B , 88=X , 89=Y , 43=+
//coba tambah debounce
const int DEBOUNCE_DELAYstart = 50; 
int lastSteadyStatestart = LOW;       
int lastFlickerableStatestart = LOW;  
int currentStatestart;
unsigned long lastDebounceTimestart = 0;

const int DEBOUNCE_DELAYstop = 50; 
int lastSteadyStatestop = LOW;       
int lastFlickerableStatestop = LOW;  
int currentStatestop;
unsigned long lastDebounceTimestop = 0;

const int DEBOUNCE_DELAYplus = 50; 
int lastSteadyStateplus = LOW;       
int lastFlickerableStateplus = LOW;  
int currentStateplus;
unsigned long lastDebounceTimeplus = 0;

void setup()
{
 // initialize UART at 9600bps
 Serial.begin(9600);
 // initialize the digital pin as an output.
 pinMode(led, OUTPUT);
 pinMode(Start, INPUT_PULLUP);
 pinMode(Stop, INPUT_PULLUP);
 pinMode(Plus, INPUT_PULLUP);
}

void loop(){
  //ini untuk start
  currentStatestart = digitalRead(Start);
   if (currentStatestart != lastFlickerableStatestart) {
    // reset the debouncing timer
    lastDebounceTimestart = millis();
    // save the the last flickerable state
    lastFlickerableStatestart = currentStatestart;
  }
  //ini untuk stop
  currentStatestop = digitalRead(Stop);
   if (currentStatestop != lastFlickerableStatestop) {
    // reset the debouncing timer
    lastDebounceTimestop = millis();
    // save the the last flickerable state
    lastFlickerableStatestop = currentStatestop;
  }
    //ini untuk plus
  currentStateplus = digitalRead(Plus);
   if (currentStateplus != lastFlickerableStateplus) {
    // reset the debouncing timer
    lastDebounceTimeplus = millis();
    // save the the last flickerable state
    lastFlickerableStateplus = currentStateplus;
  }
  //ini untuk start
if ((millis() - lastDebounceTimestart) > DEBOUNCE_DELAYstart) {
    // whatever the reading is at, it's been there for longer than the debounce
    // delay, so take it as the actual current state:

    // if the button state has changed:
    if (lastSteadyStatestart == LOW && currentStatestart == HIGH){
      Serial.write(startByte);
    }
    // save the the last steady state
    lastSteadyStatestart = currentStatestart;
  }

  //ini untuk stop
if ((millis() - lastDebounceTimestop) > DEBOUNCE_DELAYstop) {
    // whatever the reading is at, it's been there for longer than the debounce
    // delay, so take it as the actual current state:

    // if the button state has changed:
    if (lastSteadyStatestop == LOW && currentStatestop == HIGH){
      Serial.write(stopByte);
    }
    // save the the last steady state
    lastSteadyStatestop = currentStatestop;
  }

  //ini untuk plus
if ((millis() - lastDebounceTimeplus) > DEBOUNCE_DELAYplus) {
    // whatever the reading is at, it's been there for longer than the debounce
    // delay, so take it as the actual current state:

    // if the button state has changed:
    if (lastSteadyStateplus == LOW && currentStateplus == HIGH){
      Serial.write(plusByte);
    }
    // save the the last steady state
    lastSteadyStateplus = currentStateplus;
  }

  //INI untuk baca perintah dari VBNet
 if (Serial.available() > 0)  {
    inByte=Serial.read();
    Serial.write(inByte);
      if (inByte==65)
      {
      digitalWrite(led, HIGH);   // turn the LED on (Tekan Huruf A)
      }
      if (inByte==66)
      {
      digitalWrite(led, LOW);    // turn the LED off (Tekan Huruf B)
      }
    }
    
}
