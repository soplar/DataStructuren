<?php
// https://www.w3schools.com/php/php_arrays.asp
    $autos = array("Volvo", "BMW", "Toyota");
    echo $autos[2] . "\n";
    // functies gebruiken met arrays
    $lengte_array = count($autos);
    sort($autos);
    echo "Lengte van de array: " . $lengte_array . "\n";
    // loopje
    for($x = 0; $x < $lengte_array; $x++) {
        echo $autos[$x];
        echo "\n";
    }
    // test: php php_indexed.php
?>