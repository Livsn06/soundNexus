
<?php

   
require '../services/nusoap.php';
$client = new nusoap_client('http://localhost/IPT/soundNexus/services/webService.php?wsdl');

$res = "";
$search = "";
$type ="";

if(isset( $_GET['type'] , $_GET['search'])){


    $search = trim($_GET['search']);
    $type = trim($_GET['type']);
 
    $_SESSION['search'] =  $search;

    try{
 
        $res = $client -> call("searchAlbum", array("searchalbums" => $search, "searchtype" => $type));
        // echo $res;

    }catch(Exception $ex){
        echo $ex -> getMessage();
    }


}else{

    try{
 
        $res = $client -> call("getAllAlbum");
        // echo $res;

    }catch(Exception $ex){
        echo $ex -> getMessage();
    }

    
}

$res = json_decode($res, true);

if($res != null){
    foreach ($res as $index => $data){

        echo "
            <h3>Album: ".$data['title']."</h3>
            <p>
                |<b>Artist: </b> ".$data['artist'].
                "&#160&#160|<b>Genre: </b>".$data['genre'].
                "&#160&#160|<b>Year Release: </b>".$data['year']."
            </p>
        ";

        $song = $client -> call("searchAlbumSongs", array("searchsong" => $data['title']));
        // echo $song;
        $song = json_decode($song, true);
        

        if($song != null){

            echo "
            <table border=\"1\" style=\"border-collapse: collapse; width: 50%; text-align: center;\">
            <thead>
                <tr>
                    <th>Song Title</th>
                    <th>Stream Audio</th>
                </tr>
            </thead>
            <tbody>" ;
            foreach($song as $i => $d){
                $embedLink = str_replace("watch?v=", "embed/", $d['file']);
                $title = $d['title'];
                echo "
                        <tr>
                            <td>".$title."</td>
                            <td>            
                                <iframe width=\"250\" height=\"150\"
                                src='".$embedLink."' allowfullscreen>
                                </iframe>
                            </td>
                        </tr>
                ";
                
            }

            echo "
                </tbody>
                </table>
            ";
        }else{

            echo '
                <div style="margin: 0 auto; text-align: center;">
                    <p style="color: red; font-size:medium;">no music found..</p>
                    <img src="https://media.tenor.com/oXkW9LLAGG8AAAAM/oshi-no-ko-head-bob.gif" alt="icon" width="120">
                </div>
            ';
        }

        echo '   <hr>';

    }
}else{
    echo '
    <div style="margin: 0 auto; text-align: center; padding-top: 120px;">
        <p style="color: red; font-size:medium;">'.$type.' not found..</p>
        <img src="https://png.pngtree.com/png-vector/20190809/ourlarge/pngtree-find-search-view-error-abstract-flat-color-icon-template-png-image_1652318.jpg" alt="icon" width="170">
    </div>
';
}
?>


