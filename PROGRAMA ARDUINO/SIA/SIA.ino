#include <Ethernet.h>
#include <EEPROM.h>
#include <LiquidCrystal_PCF8574.h>
#include <TrueRandom.h>
#include <FPM.h>

#define RESET 6
#define RESTART 5

LiquidCrystal_PCF8574 lcd(0x3f);

FPM finger;

EthernetClient client;
EthernetServer server(80);

byte mac[6] = { 0x90, 0xA2, 0xB4, 0x00, 0x00, 0x00 };
byte ipTerminal[4] = {0 ,0, 0, 0};
byte SerDNS[4] = {0 ,0, 0, 0};
byte PEnlace[4] = {0 ,0, 0, 0};
byte MascRed[4] = {0 ,0, 0, 0};
byte ipServer[4] = {0 ,0, 0, 0};

String NombreTerminal;

int eeAddress = 0;
int Hor = 0;
int Min = 0;
int Sec = 0;
int DHCP = 1;
int TMSG = 1500; 

boolean PrimerArranque = true;
boolean msg = true;
boolean CR = false;
boolean ContinuarEnrroll = true;

unsigned long TR = 0;
unsigned long TRC = 0;
unsigned long UltE = 0;
unsigned long UltR = 0;
unsigned long UltA = 0;

float RestR = 0;

const String VER_HORA = "GET /scripts/VerHora.php?";
const String ASISTENCIA = "GET /scripts/Asistencia.php?";
const String VER_ESTADO = "GET /scripts/VerEstado.php?";
const String SINCRONIZAR = "GET /scripts/Sincronizar.php?";
const String MOD_ESTADO = "GET /scripts/modEstado.php?";
const String TABLA_DIARIA = "GET /scripts/TablaDiaria.php?";

void ConfigTerminal();
void IniciarSIA();
boolean RecibirConfig();
void CargarConfiguracion();
void Reset();
void RegistrarEntradas();
void MensajesErrorFP(int p);
void lcd_posiciona (int lcd_largo, int lcd_alto, int lcdy, int centrar, String texto);
void Reloj();
void ConfReloj();
int getFingerprintEnroll(int id);
String VerActualizacion();
void SincronizarHuellas();
void PeticionHTTP(String Peticion, int NumR = 0, String *Datos = 0, int NumP = 0, String Parametros[] = {'-'}, String Nombres[] = {'-'});

void setup() {
  Serial.begin(9600);
  Serial1.begin(57600);

  lcd.begin(16, 2);
  lcd.setBacklight(255);

  pinMode(RESET, INPUT);
  
  server.begin();

  EEPROM.get(eeAddress, PrimerArranque);
  eeAddress += sizeof(boolean);
  
  if(PrimerArranque  == true){
    ConfigTerminal();
  }
  else{
    CargarConfiguracion();
    IniciarSIA();
  }
}

void loop() {
  if (msg == true) {
    lcd_posiciona(16, 2, 1, 3, "SISTEMA");
    lcd_posiciona(16, 2, 2, 3, "SIA");
    msg = false;
  }

  if (RecibirConfig()) {
    lcd.clear();
    lcd.home();
        
    delay(2000);
       
    pinMode(RESTART, OUTPUT);
  }

  if(CR == false){
    ConfReloj();
  }

  if (((String)Hor + ":" + (String)Min) == "0:05") {
    if ((millis() - UltE) >= 20000) {
      if (VerActualizacion() == "SI") {
        SincronizarHuellas();
      } 

      UltE = millis();
    }
  }

  if (((String)Hor + ":" + (String)Min) == "0:10") {
    if ((millis() - UltA) >= 25000) {
      String Respuesta [1];
      
      PeticionHTTP(TABLA_DIARIA, 1, Respuesta);
      UltA = millis();
    }
  }

  if (((String)Hor + ":" + (String)Min) == "0:15" || ((String)Hor + ":" + (String)Min) == "12:15") {
    if ((millis() - UltR) >= 25000) {
      CR = false;
      UltR = millis();
    }
  }
  
  Reloj();
  Reset();
  RegistrarEntradas();
}

void SincronizarHuellas() {
  lcd.home();
  lcd.clear();
  
  lcd_posiciona(16, 2, 1, 3, "SINCRONIZANDO");
  lcd_posiciona(16, 2, 2, 3, "HUELLAS");
    
  String Respuesta[3];
  String Parametros[1];
  String Nombres[1];
  int i = 0;
  int intento = 0;

  Nombres[0] = "CONT";
  Parametros[0] = i;

  PeticionHTTP(SINCRONIZAR, 3, Respuesta, 1, Parametros, Nombres);

  while(Respuesta[2] != "FIN"){
    if (Respuesta[0] != "" && Respuesta[0] != "PPOPL") {  
      finger.uploadModel();
      
      int index = 0;
      uint32_t starttime = millis();
    
      while ((index < 256) && ((millis() - starttime) < 1000)) {
        uint8_t B = Respuesta[1].substring(index, index + 1).toInt();
        Serial1.write(B);
        index++;
      }

      int p = finger.storeModel(Respuesta[0].toInt());
      if (p == FINGERPRINT_OK) {
        i++;
        intento = 0;
      }

      if (intento == 2) {
        i++;
        intento = 0;
      }

      Parametros[0] = i;
    
      PeticionHTTP(SINCRONIZAR, 3, Respuesta, 1, Parametros, Nombres);
      intento = 0;
    }
    else {
      lcd_posiciona(16, 2, 1, 3, "SINCRONIZANDO");
      lcd_posiciona(16, 2, 2, 3, "HUELLAS");
    }
  }

  String Resultado[1];

  while(Resultado[0] != "MOD"){
    PeticionHTTP(MOD_ESTADO, 1, Resultado);
    delay(500);
  }
  
  lcd.home();
  lcd.clear();  

  msg = true;
}

void ConfReloj(){
  if((millis() - TRC) >= 5000){
    String Hora[3];
      
    PeticionHTTP(VER_HORA, 3, Hora);

    if(Hora[0] != "" && Hora[0] != "PPOPL"){
      Hor = Hora[0].toInt();
      Min = Hora[1].toInt();
      Sec = Hora[2].toInt();

      CR = true;

      TR = millis();
    }
    else{
      CR = false;
    }

    TRC = millis();
  }
}

int getFingerprintEnroll(int id) {
  HUELLA:
  int p = -1;

  lcd.home();
  lcd.clear();

  lcd_posiciona(16, 2, 1, 3, "APOYA");
  lcd_posiciona(16, 2, 2, 3, "EL DEDO");

  while (p != FINGERPRINT_OK) {
    client = server.available();

    if(!client.available()){ 
      p = finger.getImage();

      switch (p) {
        case FINGERPRINT_OK: break;
        case FINGERPRINT_NOFINGER: break;
        case FINGERPRINT_PACKETRECIEVEERR: MensajesErrorFP(p); goto HUELLA;
        case FINGERPRINT_IMAGEFAIL: MensajesErrorFP(p); goto HUELLA;
        default: MensajesErrorFP(p); goto HUELLA;
      }
      yield();
    }
    else {
      char Comando = client.read(); 

      if(Comando == 'N'){ 
        lcd.home();
        lcd.clear();
        
        lcd_posiciona(16, 2, 1, 3, "OPERACION");
        lcd_posiciona(16, 2, 2, 3, "CANCELADA");

        delay(TMSG);
    
        lcd.home();
        lcd.clear();
    
        lcd_posiciona(16, 2, 1, 3, "ESPERANDO");
        lcd_posiciona(16, 2, 2, 3, "ALUMNO");

        client.write("OK");
        client.flush();

        return 0;
      }
    }
  }

  p = finger.image2Tz(1);
  switch (p) {
    case FINGERPRINT_OK: break;
    case FINGERPRINT_IMAGEMESS: MensajesErrorFP(p); goto HUELLA;
    case FINGERPRINT_PACKETRECIEVEERR: MensajesErrorFP(p); goto HUELLA;
    case FINGERPRINT_FEATUREFAIL: goto HUELLA;
    case FINGERPRINT_INVALIDIMAGE: goto HUELLA;
    default: MensajesErrorFP(p); goto HUELLA;
  }

  lcd.home();
  lcd.clear();

  lcd_posiciona(16, 2, 1, 3, "RETIRA");
  lcd_posiciona(16, 2, 2, 3, "EL DEDO");

  p = 0;
  while (p != FINGERPRINT_NOFINGER) {
    p = finger.getImage();
    yield();
  }

  p = -1;
  
  lcd.home();
  lcd.clear();

  lcd_posiciona(16, 2, 1, 3, "VUELVA A");
  lcd_posiciona(16, 2, 2, 3, "PONER EL DEDO");

  while (p != FINGERPRINT_OK) {
    client = server.available();

    if(!client.available()){ 
      p = finger.getImage();
    
      switch (p) {
        case FINGERPRINT_OK: break;
        case FINGERPRINT_NOFINGER: break;
        case FINGERPRINT_PACKETRECIEVEERR: MensajesErrorFP(p); goto HUELLA;
        case FINGERPRINT_IMAGEFAIL: MensajesErrorFP(p); goto HUELLA;
        default: MensajesErrorFP(p); goto HUELLA;
      }
      yield();
    }
    else {
      char Comando = client.read(); 

      if(Comando == 'N'){ 
        lcd.home();
        lcd.clear();
        
        lcd_posiciona(16, 2, 1, 3, "OPERACION");
        lcd_posiciona(16, 2, 2, 3, "CANCELADA");

        delay(TMSG);
        
        lcd.home();
        lcd.clear();
    
        lcd_posiciona(16, 2, 1, 3, "ESPERANDO");
        lcd_posiciona(16, 2, 2, 3, "ALUMNO");

        client.write("OK");
        client.flush();

        return 0;
      }
      
    }
  }
  
  p = finger.image2Tz(2);
  switch (p) {
    case FINGERPRINT_OK: break;
    case FINGERPRINT_IMAGEMESS: MensajesErrorFP(p); goto HUELLA;
    case FINGERPRINT_PACKETRECIEVEERR: MensajesErrorFP(p); goto HUELLA;
    case FINGERPRINT_FEATUREFAIL: goto HUELLA;
    case FINGERPRINT_INVALIDIMAGE: goto HUELLA;
    default: MensajesErrorFP(p); goto HUELLA;
  }

  p = finger.createModel();
  if (p == FINGERPRINT_OK) {
    finger.getModel();

    String model;
    int index = 0;
    uint32_t starttime = millis();
    
    while ((index < 256) && ((millis() - starttime) < 1000)) {
      if (Serial1.available()) {
        uint8_t c = Serial1.read(); 
        model = model + c;
        index++;
      }
    }

    while (!client.available()) {
      client = server.available();
      server.print(model);
    }
   
    client.read();
    client.write("OK");
    client.flush();
    
    lcd.home();
    lcd.clear();
  
    lcd_posiciona(16, 2, 1, 3, "HUELLA");
    lcd_posiciona(16, 2, 2, 3, "CAPTURADA");

    delay(TMSG);

    lcd.home();
    lcd.clear();

    lcd_posiciona(16, 2, 1, 3, "TERMINE");
    lcd_posiciona(16, 2, 2, 3, "DE GUARDAR");

    while (!client.available()) {
      client = server.available();
    }

    char Comando = client.read(); 

    lcd.home();
    lcd.clear();

    finger.deleteModel(id);

    if(Comando == 'O'){ 
      p = finger.storeModel(id);
      if (p == FINGERPRINT_OK) {
        lcd_posiciona(16, 2, 1, 3, "HUELLA");
        lcd_posiciona(16, 2, 2, 3, "GUARDADA");
      }
      else if (p == FINGERPRINT_PACKETRECIEVEERR) { MensajesErrorFP(p); goto HUELLA; }
      else if (p == FINGERPRINT_BADLOCATION) { MensajesErrorFP(p); goto HUELLA; }
      else if (p == FINGERPRINT_FLASHERR) { MensajesErrorFP(p); goto HUELLA;; }
      else { MensajesErrorFP(p); goto HUELLA; }
    }
    else if(Comando == 'N'){
      lcd_posiciona(16, 2, 1, 3, "OPERACION");
      lcd_posiciona(16, 2, 2, 3, "CANCELADA");
    }

    delay(TMSG);

    lcd.home();
    lcd.clear();
    
    lcd_posiciona(16, 2, 1, 3, "ESPERANDO");
    lcd_posiciona(16, 2, 2, 3, "ALUMNO");
  
    client.write("OK");
    client.flush();

    return 0;
  }
  else if (p == FINGERPRINT_PACKETRECIEVEERR) { goto HUELLA; }
  else if (p == FINGERPRINT_ENROLLMISMATCH) { MensajesErrorFP(p); goto HUELLA; }
  else { MensajesErrorFP(p); goto HUELLA;}

  //finger.loadModel(id);

}

void Reloj(){
  float Dif = (millis() - TR);
  Dif = Dif + RestR;
  float Comp = (Dif / 1000);
  Comp = Comp * 8,333333333333333;
  Dif = Dif + Comp;
  
  if(Dif >= 1000){
    while(Dif >= 1000){
      if(Sec < 59){
        Sec++;
      }
      else {
        if (Min < 59) {
          Min++;
          Sec = 0;
        }
        else {
          if (Hor < 23) {
            Hor++;
            Min = 0;
            Sec = 0;
          }
          else {
            Hor = 0;
            Min = 0;
            Sec = 0;
          }
        }
      }

      Dif = Dif - 1000;
    }

    RestR = Dif;
    
    TR = millis();
    
    Serial.println((String)Hor + ":" + (String)Min + ":" + (String)Sec);
  }
}

void MensajesErrorFP(int p) {
  if (p == FINGERPRINT_PACKETRECIEVEERR) {
    lcd.home();
    lcd.clear();

    lcd_posiciona(16, 2, 1, 3, "ERROR DE");
    lcd_posiciona(16, 2, 2, 3, "COMUNICACION");

    delay(TMSG);

    lcd.home();
    lcd.clear();
  }
  else if (p == FINGERPRINT_IMAGEFAIL) {
    lcd.home();
    lcd.clear();

    lcd_posiciona(16, 2, 1, 3, "ERROR DE");
    lcd_posiciona(16, 2, 2, 3, "IMAGEN");

    delay(TMSG);

    lcd.home();
    lcd.clear();
  }
  else if (p == FINGERPRINT_ENROLLMISMATCH) {
    lcd.home();
    lcd.clear();

    lcd_posiciona(16, 2, 1, 3, "HUELLAS NO");
    lcd_posiciona(16, 2, 2, 3, "COINCIDEN");

    delay(TMSG);

    lcd.home();
    lcd.clear();
  }
  else if (p == FINGERPRINT_BADLOCATION) {
    lcd.home();
    lcd.clear();

    lcd_posiciona(16, 2, 1, 3, "ERROR AL");
    lcd_posiciona(16, 2, 2, 3, "GUARDAR");

    delay(TMSG);

    lcd.home();
    lcd.clear();
  }
  else if (p == FINGERPRINT_FLASHERR) {
    lcd.home();
    lcd.clear();

    lcd_posiciona(16, 2, 1, 3, "ERROR AL");
    lcd_posiciona(16, 2, 2, 3, "GUARDAR");

    delay(TMSG);

    lcd.home();
    lcd.clear();
  }
  else if (p == FINGERPRINT_NOTFOUND) {
    lcd.home();
    lcd.clear();

    lcd_posiciona(16, 2, 1, 3, "NO SE ENCONTRO");
    lcd_posiciona(16, 2, 2, 3, "NINGUN ALUMNO");

    delay(TMSG);

    lcd.home();
    lcd.clear();
  }
  else if (p == FINGERPRINT_IMAGEMESS || p == FINGERPRINT_FEATUREFAIL || p == FINGERPRINT_INVALIDIMAGE) {
    lcd.home();
    lcd.clear();

    lcd_posiciona(16, 2, 1, 3, "ERROR HUELLA");
    lcd_posiciona(16, 2, 2, 3, "MAL TOMADA");

    delay(TMSG);

    lcd.home();
    lcd.clear();
  }
  else {
    lcd.home();
    lcd.clear();

    lcd_posiciona(16, 2, 1, 3, "ERROR");
    lcd_posiciona(16, 2, 2, 3, "DESCONOCIDO");

    delay(TMSG);

    lcd.home();
    lcd.clear();
  }

  msg = true;
}

void RegistrarEntradas() {
  int p = -1;
  
  p = finger.getImage();
  if (p == FINGERPRINT_OK){  
    switch (p) {
      case FINGERPRINT_OK: break;
      case FINGERPRINT_NOFINGER: break;
      case FINGERPRINT_PACKETRECIEVEERR: MensajesErrorFP(p); break;
      case FINGERPRINT_IMAGEFAIL: MensajesErrorFP(p); break;
      default: MensajesErrorFP(p); break;
    }
    yield();

    p = finger.image2Tz();
    switch (p) {
      case FINGERPRINT_OK: break;
      case FINGERPRINT_IMAGEMESS: MensajesErrorFP(p); return '0';
      case FINGERPRINT_PACKETRECIEVEERR: MensajesErrorFP(p); return '0';
      case FINGERPRINT_FEATUREFAIL: MensajesErrorFP(p); return '0';
      case FINGERPRINT_INVALIDIMAGE: MensajesErrorFP(p); return '0';
      default: MensajesErrorFP(p); return '0';
    }

    p = finger.fingerFastSearch();
    if (p == FINGERPRINT_OK) {
      String Respuesta[1];
      String Parametros[1];
      String Nombres[1];

      Parametros[0] = finger.fingerID;
      Nombres[0] = "ID";
      
      PeticionHTTP(ASISTENCIA, 1, Respuesta, 1, Parametros, Nombres);
      
      lcd.clear();
      lcd.home();

      if (Respuesta[0] != "NOB" && Respuesta[0] != "NOH" && Respuesta[0] != "" && Respuesta[0] != "PPOPL") {
        if (Respuesta[0] == "PRE") {
          lcd_posiciona(16, 2, 1, 3, "YA ESTAS");
          lcd_posiciona(16, 2, 2, 3, "PRESENTE");

          delay(TMSG);
        
          lcd.clear();
          lcd.home();
        }
        else {
          Respuesta[0] = Respuesta[0].substring(0, Respuesta[0].indexOf(" "));

          if (Respuesta[0].indexOf(",") >= 0) {
            Respuesta[0] = Respuesta[0].substring(0, Respuesta[0].indexOf(","));
          }

          Respuesta[0].toUpperCase();
        
          lcd_posiciona(16, 2, 1, 3, "BIENVENIDO");
          lcd_posiciona(16, 2, 2, 3, Respuesta[0]);

          delay(TMSG);
        
          lcd.clear();
          lcd.home();
        }
      }
      else if (Respuesta[0] == "NOB") {       
        lcd_posiciona(16, 2, 1, 3, "NO SE ENCONTRO");
        lcd_posiciona(16, 2, 2, 3, "NINGUN ALUMNO");

        delay(TMSG);
        
        lcd.clear();
        lcd.home();
      }
      else if (Respuesta[0] == "NOH") {
        lcd_posiciona(16, 2, 1, 3, "NO TIENES");
        lcd_posiciona(16, 2, 2, 3, "CLASES");

        delay(TMSG);
        
        lcd.clear();
        lcd.home();
      }
    } 
    else if (p == FINGERPRINT_PACKETRECIEVEERR) { MensajesErrorFP(p); return '0'; }
    else if (p == FINGERPRINT_NOTFOUND) { MensajesErrorFP(p); return '0'; } 
    else { MensajesErrorFP(p); return '0'; }   
    
    msg = true;
  }
}

void Reset() {
  if (digitalRead(RESET) == HIGH) {
    unsigned long TiempoP = millis();

    while(digitalRead(RESET) == HIGH){
      if ((millis() - TiempoP) >= 10000) {
        eeAddress = 0;
        PrimerArranque = true;
        EEPROM.put(eeAddress, PrimerArranque);

        lcd.clear();
        lcd.home();
        
        delay(2000);
        
        pinMode(RESTART, OUTPUT);
      }
    }
  }
}

void CargarConfiguracion(){
  for (int i = 3; i < 6; i++) {
    EEPROM.get(eeAddress, mac[i]);
    eeAddress += sizeof(byte);
  }
  
  EEPROM.get(eeAddress, NombreTerminal);
  eeAddress += sizeof(String);
  
  EEPROM.get(eeAddress, DHCP);
  eeAddress += sizeof(int);

  if (DHCP == 0) {
    for (int i = 0; i < 4; i++) {
      EEPROM.get(eeAddress, ipTerminal[i]);
      eeAddress += sizeof(byte);
    }

    for (int i = 0; i < 4; i++) {
      EEPROM.get(eeAddress, PEnlace[i]);
      eeAddress += sizeof(byte);
    }

    for (int i = 0; i < 4; i++) {
      EEPROM.get(eeAddress, MascRed[i]);
      eeAddress += sizeof(byte);
    }

    for (int i = 0; i < 4; i++) {
      EEPROM.get(eeAddress, SerDNS[i]);
      eeAddress += sizeof(byte);
    }

    for (int i = 0; i < 4; i++) {
      EEPROM.get(eeAddress, ipServer[i]);
      eeAddress += sizeof(byte);
    }
  }
}

void ConfigTerminal() { 
  for (int i = 3; i < 6; i++) {
    mac[i] = TrueRandom.randomByte();
    EEPROM.put(eeAddress, mac[i]);
    eeAddress += sizeof(byte);
  }

  lcd_posiciona(16, 2, 1, 3, "CONECTANDO");
  lcd_posiciona(16, 2, 2, 3, "A LA RED");
  
  while(Ethernet.begin(mac) == 0) {
  }
    
  lcd.home();
  lcd.clear();

  lcd_posiciona(16, 2, 1, 3, "ESPERANDO");
  lcd_posiciona(16, 2, 2, 3, "CONFIGURACION");
  
  while(!RecibirConfig()){}
  
  eeAddress = 0;
  PrimerArranque = false;
  EEPROM.put(eeAddress, PrimerArranque);

  lcd.clear();
  lcd.home();
        
  delay(2000);
        
  pinMode(RESTART, OUTPUT);
}

void IniciarSIA(){
  INICIAR:
    lcd.home();
    lcd.clear();
    
    lcd_posiciona(16, 2, 1, 3, "INCIANDO");
    lcd_posiciona(16, 2, 2, 3, "SIA");

    if (!finger.begin(&Serial1)) {
      lcd.home();
      lcd.clear();
    
      lcd_posiciona(16, 2, 1, 3, "EL LECTOR");
      lcd_posiciona(16, 2, 2, 3, "NO FUNCIONA");

      while (1) yield();
    }

    if (DHCP == 1) {
      while(Ethernet.begin(mac) == 0) {
        if (Ethernet.linkStatus() == LinkOFF) {
          lcd.home();
          lcd.clear();
    
          lcd_posiciona(16, 2, 1, 3, "CABLE ETHERNET");
          lcd_posiciona(16, 2, 2, 3, "DESCONECTADO");

          while (Ethernet.linkStatus() == LinkOFF) {}

          goto INICIAR;
        }
        else {
          lcd.home();
          lcd.clear();
    
          lcd_posiciona(16, 2, 1, 3, "RED NO");
          lcd_posiciona(16, 2, 2, 3, "CONECTADA");
        }
      }
    }
    else {
      Ethernet.begin(mac, ipTerminal, SerDNS, PEnlace, MascRed);
    }
     
    if (!client.connect(ipServer, 8080)) {
     lcd.home();
     lcd.clear();
        
     lcd_posiciona(16, 2, 1, 3, "SIN CONEXION");
     lcd_posiciona(16, 2, 2, 3, "AL SERVIDOR");
        
      while (!client.connect(ipServer, 8080)){
        if (RecibirConfig()) {
          lcd.clear();
          lcd.home();
        
          delay(2000);
        
          pinMode(RESTART, OUTPUT);
        }

        Reset();
      }
    }
    
    lcd.home();
    lcd.clear();
}

boolean RecibirConfig(){
  client = server.available();

  if(client.available()){ 
    char Comando = client.read(); 

    client.write("OK");
    client.flush();
    
    if(Comando == 'C'){
      String Datos[7];
  
      for(int i = 0; i < 7; i++){
        while (!client.available()) {
          client = server.available();
        }

        while (client.available()) {
          char c = client.read();
          Datos[i] = Datos[i]  + c;
          delay(1);
        }

        client.write("OK");
        client.flush();

        if(Datos[i] == "Automatico"){
          break;
        } 
      }

      eeAddress = 0;
      eeAddress += sizeof(boolean);
  
      for (int i = 0; i < 3; i++) {
        eeAddress += sizeof(byte);
      }

      NombreTerminal = Datos[0];
      EEPROM.put(eeAddress, NombreTerminal);
      eeAddress += sizeof(String);

      if(Datos[1] == "Automatico"){
        DHCP = 1;
        EEPROM.put(eeAddress, DHCP);
        eeAddress += sizeof(int);
      }
      else{
        DHCP = 0;
        EEPROM.put(eeAddress, DHCP);
        eeAddress += sizeof(int);

        for (int i = 0; i < 4; i++) {
          ipTerminal[i] = Datos[2].substring(0, Datos[2].indexOf(".")).toInt();     
          Datos[2] = Datos[2].substring(Datos[2].indexOf(".") + 1, Datos[2].length());    
          EEPROM.put(eeAddress, ipTerminal[i]);
          eeAddress += sizeof(byte);
        }

        for (int i = 0; i < 4; i++) {
          PEnlace[i] = Datos[3].substring(0, Datos[3].indexOf(".")).toInt();     
          Datos[3] = Datos[3].substring(Datos[3].indexOf(".") + 1, Datos[3].length());    
          EEPROM.put(eeAddress, PEnlace[i]);
          eeAddress += sizeof(byte);
        }

        for (int i = 0; i < 4; i++) {
          MascRed[i] = Datos[4].substring(0, Datos[4].indexOf(".")).toInt();   
          Datos[4] = Datos[4].substring(Datos[4].indexOf(".") + 1, Datos[4].length());      
          EEPROM.put(eeAddress, MascRed[i]);
          eeAddress += sizeof(byte);
        }
    
        for (int i = 0; i < 4; i++) {
          SerDNS[i] = Datos[5].substring(0, Datos[5].indexOf(".")).toInt();   
          Datos[5] = Datos[5].substring(Datos[5].indexOf(".") + 1, Datos[5].length());    
          EEPROM.put(eeAddress, SerDNS[i]);
          eeAddress += sizeof(byte);
        }
    
        for (int i = 0; i < 4; i++) {
          ipServer[i] = Datos[6].substring(0, Datos[6].indexOf(".")).toInt();  
          Datos[6] = Datos[6].substring(Datos[6].indexOf(".") + 1, Datos[6].length());       
          EEPROM.put(eeAddress, ipServer[i]);
          eeAddress += sizeof(byte);
        }
      } 
    
      client.write("OK");
      client.flush();

      return true;
    }
    else if (Comando == 'S') {
      String IPS;
      
      while (!client.available()) {
        client = server.available();
      }

      while (client.available()) {
        char c = client.read();
        IPS = IPS  + c;
        delay(1);
      }

      client.write("OK");
      client.flush();
      
      eeAddress = 0;
      eeAddress += sizeof(boolean);
        
      for (int i = 0; i < 3; i++) {
        eeAddress += sizeof(byte);
      }

      eeAddress += sizeof(String);
      eeAddress += sizeof(int);

      for (int i = 0; i < 16; i++) {
        eeAddress += sizeof(byte);
      }
      
      for (int i = 0; i < 4; i++) {
        ipServer[i] = IPS.substring(0, IPS.indexOf(".")).toInt();  
        IPS = IPS.substring(IPS.indexOf(".") + 1, IPS.length());       
        EEPROM.put(eeAddress, ipServer[i]);
        Serial.println(ipServer[i]);
        eeAddress += sizeof(byte);
      }

      return true;
    }
    else if(Comando == 'E') {
      lcd.clear();
      lcd.home();
    
      lcd_posiciona(16, 2, 1, 3, "ESPERANDO");
      lcd_posiciona(16, 2, 2, 3, "ALUMNO");
    
      while (ContinuarEnrroll == true) {
        int id = 0;
        String Aux;
        
        client = server.available();

        if (client.available()) {
          while (client.available()) {
            char c = client.read();
            Aux = Aux + c;
            delay(1);
          }
        
          client.write("OK");
          client.flush();

          if(Aux == 'X') {
            break;
          }

          id = Aux.toInt();

          if (id != 0) {
            getFingerprintEnroll(id);
          }
          else {
            ContinuarEnrroll = false;
          }
        }
      }
      
      ContinuarEnrroll = true;
      
      lcd.clear();
      lcd.home();
      
      msg = true;

      return false;
    }
  }
  else {
    return false;
  }
}

String VerActualizacion() {
  String Respuesta[1];
  
  PeticionHTTP(VER_ESTADO, 1, Respuesta);

  if (Respuesta[0] == "ACT") {
    int p = finger.emptyDatabase();
    if (p == FINGERPRINT_OK){
      return "SI";
    }
   else if (p == FINGERPRINT_PACKETRECIEVEERR) { return "ERROR"; } 
   else if (p == FINGERPRINT_DBCLEARFAIL) { return "ERROR"; }
   else { return "ERROR"; }
  }
  else if(Respuesta[0] == "NOA") {
    return "NO";
  }
  else if(Respuesta[0] == "NOE") {
    return "NO";
  }
}

void PeticionHTTP(String Peticion, int NumR = 0, String *Datos = 0, int NumP = 0, String Parametros[] = {'-'}, String Nombres[] = {'-'}){ 
  if (client.connect(ipServer, 8080)) {
    if(NumP > 0){
      for(int i = 0; i < NumP; i++){
        Peticion = Peticion + Nombres[i];
        Peticion = Peticion + "=";
        Peticion = Peticion + Parametros[i];
       
        if((NumP - 1) > i){
          Peticion = Peticion + "&";
        }
      }
    }
    
    client.print(Peticion);
    client.println();

    if(NumR > 0){         
      String Result;
       
      while (!client.available()) {
      }

      while (client.available()) {
        char c = client.read();
        Result = Result + c;
        delay(1);
      }    

      for(int i = 0; i < NumR; i++){
        Result = Result.substring(Result.indexOf("<p>") + 3, Result.length());                
        Datos[i] = Result.substring(0, Result.indexOf("<p>"));     
      }
    }

    client.stop();
  }
  else {
    lcd.home();
    lcd.clear();

    lcd_posiciona(16, 2, 1, 3, "SIN CONEXION");
    lcd_posiciona(16, 2, 2, 3, "AL SERVIDOR");

    delay(TMSG);

    lcd.home();
    lcd.clear();
  }

  msg = true;
  delay(70);
}

void lcd_posiciona (int lcd_largo, int lcd_alto, int lcdy, int centrar, String texto) {
  /*
    lcd_posiciona (16, 2, 1, 5, "Hola Mundo");
    16 = Numero de columnas del LCD.
    2  = Numero de filas del LCD.
    1  = Fila en la que quieremos mostrar el texto (la primera es 1).
    5  = Modo de alineacion.
    "Hola Mundo" = El texto que vamos a mostrar.

    Modos de alineacion:

    1 = Izquierda
    2 = Derecha
    3 = Centro
    4 = Aleatorio aciendo caso a la fila
    5 = Aleatorio y no hace caso a la fila
  */

  int lcdx = 0;
  int largo = texto.length();
  int sobrante = lcd_largo - largo;
  int random_sobrante = random (0, (sobrante + 1));
  int random_y = random (0, lcd_alto);

  lcdy = lcdy - 1;

  switch (centrar) {
    case 1: lcdx = 0; break;
    case 2: lcdx = sobrante; break;
    case 3: lcdx = sobrante / 2; break;
    case 4: lcdx = random_sobrante; break;
    case 5:
      lcdx = random_sobrante;
      lcdy = random_y;
      break;
    default:
      delay(0);
  }

  lcd.setCursor(lcdx, lcdy);
  lcd.print
  (texto);
}
