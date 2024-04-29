<?php

function openDB(){
    $conn = new mysqli('localhost', 'root', '', 'soundnexusdb') or die('Connection invalid.');
    return $conn;
}


?>