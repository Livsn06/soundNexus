
<form method="get" >
    Search 
    <input type="search" name="search" value=" <?php echo isset($_GET['search'])? $_GET['search'] : '' ?>"> 
    <input type="radio" name="type" value="title">Album
    <input type="radio" name="type" value="genre">Genre
    <input type="radio" name="type" value="artist">Artist
    <input type="submit" value="submit" name= "submit">
</form>

<?php
require '../request/clientside.php';
?>


