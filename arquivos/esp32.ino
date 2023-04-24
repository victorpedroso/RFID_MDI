void setup() {
  Serial.begin(115200);
}
void loop() {
  if(Serial.available()) { //verifica se há dados na porta serial
    String c = Serial.readString(); //le o dado enviado em string
    int numRecebido = atoi(c.c_str()); //converte o dado recebido para int
    if(numRecebido == 1){ //se dado recebido = 0, libera trava manualmente
      Serial.println("1 - esp32");
      delay(1500);
    }
}else{
Serial.println("UID TAG");
delay(1500);
}
}
