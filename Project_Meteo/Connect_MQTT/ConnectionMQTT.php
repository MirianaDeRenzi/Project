<!DOCTYPE html>
<html lang="it"> 
    <head>
        <title>Pagina connessione</title>
    </head>
<body>    
    <h1 style="font-family:verdana;">Premi il pulsante per attivare la comunicazione</h1>
        <form action ="Communication.php" method="post" >
            <button lass="my-button" >Avvia Comunicazione</button>
        </form>
        <style>           
            button {
                    display: inline-block;
                    border-radius: 7px;
                    font-size: 20px;
                    cursor: pointer;
                    text-align: center;
                    background-color: white;
                    color: black;
                    border: 2px solid #555555;
                    transition-duration: 0.1s;
                    box-shadow: 0 9px #999;                       
                }

            button:hover{
                        background-color: #9090c5; 
                        color: white;
                        box-shadow: 0 12px 8px 0 rgba(0,0,0,0.24), 0 17px 50px 0 rgba(0,0,0,0.19);
                        }
                            
            button:active{
                            background-color: #e7e7e7;
                            box-shadow: 0 5px #666;
                            transform: translateY(4px);
                        }
        </style>
<?php

require("phpMQTT.php");

//funzione per i messaggi nella console
function debug_to_console($data)
{
    $output = $data;
    if(is_array($output))
    $output = implode(',', $output);
    echo "<script>console.log('" . $output . "' );</script>";
}

//impostazioni server mqtt
$mqtt_server = "broker.hivemq.com";
$mqtt_port = 1883;
$mqtt_username = "";//lascia  vuoto
$mqtt_password = "";//lascia  vuoto
$mqtt_topic = "Temperatura_MQTT";
$mqtt_client_id = "phpMQTT-subscriber"; 

//impostazioni database
$db_host = "localhost";
$db_username = "";//user db
$db_password = "";//pass db
$db_name = "meteotempo";

//connessione al database con mysqli
$mysqli = new mysqli($db_host, $db_username, $db_password, $db_name);
if ($mysqli->connect_errno) 
{
    debug_to_console("Connessione fallita: ". $mysqli->connect_error);
}
else
{
    debug_to_console("Connessione al database riuscita");
}

//connessione a mqtt 
$mqtt = new bluerhinos\phpMQTT($mqtt_server, $mqtt_port, $mqtt_client_id);
if (!$mqtt->connect(true, NULL, $mqtt_username, $mqtt_password)) 
{
    debug_to_console("Connessione al server mqtt non riuscita, ricaricare la pagina");
}
else
{
    debug_to_console("Connessione al server mqtt avvenuta con successo");
}
//chiudo le connessioni
$mqtt->close();
$mysqli->close();
?>
</body>
</html>