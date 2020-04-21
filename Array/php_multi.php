// https://www.w3schools.com/php/php_arrays_multidimensional.asp
<?php
    $steden = array(
        array("Amsterdam", "Noord-Holland", 872779),
        array("Rotterdam","Zuid-Holland", 651376),
        array("Den Haag", "Zuid-Holland", 545163),
        array("Utrecht", "Utrecht",	357694),
        array("Eindhoven", "Noord-Brabant", 234456),
        array("Groningen", "Groningen", 232922),
        array("Tilburg", "Noord-Brabant", 219800)
    );
    echo $steden[4][2] . "\n"; // aantal inwoners eindhoven

    for ($row = 0; $row < count($steden); $row++) {
        echo "$row : ";
        for ($col = 0; $col < count($steden[$row]); $col++) {
          echo $steden[$row][$col]."\t";
        }
        echo "\n";
    }
?>