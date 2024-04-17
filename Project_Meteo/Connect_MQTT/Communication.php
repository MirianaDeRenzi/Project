<?php
require("phpMQTT.php");


$mqtt_server = "broker.hivemq.com";
$mqtt_port = 1883;
$mqtt_username = "";//lascia vuoto
$mqtt_password = "";//lascia vuoto
$mqtt_topic = "Temperatura_MQTT";
$mqtt_client_id = "phpMQTT-subscriber"; 

$db_host = "localhost";
$db_username = "";//user
$db_password = "";//pass
$db_name = "meteotempo";

$mysqli = new mysqli($db_host, $db_username, $db_password, $db_name);
if ($mysqli->connect_errno) 
{
    echo("Connessione fallita: ". $mysqli->connect_error);
}

//funzione per gestire i messaggi mqtt e inserirli nel database
function Messaggi_MQTT($topic, $msg) 
{
    global $mysqli;

    $Temperatura_MQTT = $mysqli->real_escape_string($msg);
	$current_time = date('Y-m-d H:i:s');
    $query = "INSERT INTO statistiche (temperatura, orario) VALUES ('$Temperatura_MQTT', '$current_time')";
    
    if ($mysqli->query($query) === TRUE) 
    {
        echo("Temperatura e orario inseriti correttamente.");
    } 
    else 
    {
        echo("Errore nell'inserimento: " . $mysqli->error);
    }
}

$mqtt = new bluerhinos\phpMQTT($mqtt_server, $mqtt_port, $mqtt_client_id);

if (!$mqtt->connect(true, NULL, $mqtt_username, $mqtt_password)) 
{
    echo("Connessione al server mqtt non riuscita, uscire e ricaricare la pagina");
}

//mi iscrivo al topic cosi da ricevere i messaggi
$topics[$mqtt_topic] = array("qos" => 0, "function" => "Messaggi_MQTT");
$mqtt->subscribe($topics, 0);

//ciclo i messaggi mqtt
while ($mqtt->proc()) {
    
}

$mqtt->close();
$mysqli->close();
?>