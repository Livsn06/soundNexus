<?php

require 'nusoap.php';
require 'wsMethods.php';

$soap = new nusoap_server();
$soap -> configureWSDL("soundNexus", "urn:soundNexusWS");

$soap -> register(
    "getAllAlbum",
    array(),
    array('response' => 'xsd:string')
);

$soap -> register(
    "getAllAlbumSongs",
    array(),
    array('response' => 'xsd:string')
);

$soap -> register(
    "searchAlbum",
    array('searchalbums' => 'xsd:string', 'searchtype' => 'xsd:string'),
    array('response' => 'xsd:string')
);

$soap -> register(
    "searchAlbumSongs",
    array('searchsong' => 'xsd:string'),
    array('response' => 'xsd:string')
);

$soap -> register(
    "addAlbumSongs",
    array('addtitle' => 'xsd:string', 'addfile' => 'xsd:string', 'addalbum' => 'xsd:string'),
    array('response' => 'xsd:string')
);

$soap -> register(
    "addAlbums",
    array('addtitle' => 'xsd:string', 'addartist' => 'xsd:string', 'addgenre' => 'xsd:string', 'adddate' => 'xsd:date'),
    array('response' => 'xsd:string')
);

$soap -> service(file_get_contents('php://input'));

?>