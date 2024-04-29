<?php
require 'connection.php';


function getAllAlbum(){
    $conn = openDB();
    $sql = "SELECT * FROM album";
    $response = $conn -> query($sql) or die("Query is invalid");

    while($result = $response -> fetch_assoc()){
        $data[] = $result;
    }
    return json_encode($data);
}

function getAllAlbumSongs(){
    $conn = openDB();
    $sql = "SELECT * FROM song";
    $response = $conn -> query($sql) or die("Query is invalid");

    while($result = $response -> fetch_assoc()){
        $data[] = $result;
    }
    return json_encode($data);

}



// SEARCH METHODS

function searchAlbum($search, $type){
    $conn = openDB();
    $sql = "SELECT * FROM album WHERE ".$type." LIKE '%".$search."%'";
    $response = $conn -> query($sql) or die("Query is invalid");

    while($result = $response -> fetch_assoc()){
        $data[] = $result;
    }
    return json_encode($data);
}



function searchAlbumSongs($search){
    $conn = openDB();

    
    $sql = "SELECT * FROM song WHERE album LIKE '%".$search."%'";
    $response = $conn -> query($sql) or die("Query is invalid");

    while($result = $response -> fetch_assoc()){
        $data[] = $result;
    }
    return json_encode($data);

}



// ADD METHODS

function addAlbums($title, $artist, $genre, $year){
    $conn = openDB();
    $sql = "INSERT INTO album (title, artist, genre, year) VALUES ('".$title."', '".$artist."', '".$genre."', '".$year."');";
    $response = $conn -> query($sql) or die("Query is invalid");
    return $response;
}

function addAlbumSongs($title, $file, $album){
    $conn = openDB();
    $sql = "INSERT INTO song ( title, file, album) VALUES ('".$title."', '".$file."', '".$album."')";
    $response = $conn -> query($sql) or die("Query is invalid");
    return $response;
}



?>