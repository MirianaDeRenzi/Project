//librerie
#include <ESP8266WiFi.h>
#include <PubSubClient.h>
#include "DHT.h"

//impostazioni
const char mqtt_server[] = "broker.hivemq.com";
const char ssid[] = "";//inserisci ssid
const char password[] = "";//inserisci password
const char topic[] = "Temperatura_MQTT";

//definisco il sensore
#define DHTPIN D4
#define DHTTYPE DHT11
DHT dht(DHTPIN, DHTTYPE);

WiFiClient espClient;
PubSubClient client(espClient);

void Wifi() 
{
  delay(10);
  Serial.println();
  Serial.print("Collegamento a ");
  Serial.println(ssid);

  WiFi.mode(WIFI_STA); 
  WiFi.begin(ssid, password);

  while (WiFi.status() != WL_CONNECTED)
  {
    delay(500);
    Serial.print(".");
  }
  
  randomSeed(micros());

  Serial.println("");
  Serial.println("WiFi connected");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());
}

//ricezione messaggi(verifico l'effettivo invio al broker)
void callback(char* topic, byte* payload, unsigned int lenght)
{
  Serial.print("E' arrivato un messaggio sul topic: [");
  Serial.print(topic);
  Serial.print("]: " );
  
  for(unsigned int i = 0 ; i < lenght; i++)
  {
    Serial.print((char)payload[i]);
  }
  Serial.println();
}

void reconnect()
{
  while(!client.connected())
  {
    Serial.print("Mi sto riconnettendo al server MQTT. . .");

    String clientID = "ESP8266Client-";
    clientID += String(random(0xffff), HEX);
 
    if(client.connect(clientID.c_str()))
    {
      Serial.println("Connesso");
      client.subscribe("Temperatura_MQTT");
    }
    else
    { 
      Serial.print("connessione fallita, rc=");
      Serial.print(client.state());
      Serial.println(" riprovo tra 5 secondi");    
      delay(5000);
    }
  }
}

void Temperatura()
{
  float t = dht.readTemperature();

  if(isnan(t))
  {
    delay(1000);
    Serial.println("Impossibile leggere il sensore.");
  }
  else 
  {
    //conversione float->string 
    char TemperaturaString[8]; 
    dtostrf(t, 4, 2, TemperaturaString);
      
    Serial.println("sto comunicando la temperatura");
    Serial.print("Temperatura: ");
    Serial.println(TemperaturaString);

    client.publish("Temperatura_MQTT", TemperaturaString); 

    if(client.publish("Temperatura_MQTT", TemperaturaString)) 
    {
      Serial.println("Messaggio inviato con successo");
      client.setCallback(callback);
     // delay(595000);

      if(!client.connected())
      {
        reconnect();
      }
      //delay(4000);
      delay(10000);
    } 
    else
    {
      Serial.println("Errore nell'invio del messaggio");
      delay(5000);
    }
  }
}

void setup()
{
  Serial.begin(115200);
  Wifi();
  client.setServer(mqtt_server, 1883);
  client.setCallback(callback);
}

void loop()
{
  if(!client.connected())
  {
    reconnect();
  }
  client.loop();
  Temperatura();
}