<?php
$age = array("Peter"=>"35", "Ben"=>"37", "Joe"=>"43");
// en eentje erbij:
$age["Jack"] = "60";
// sorteren op key
ksort($age);
foreach($age as $x => $x_value) {
    echo "Key=" . $x . ", Value=" . $x_value;
    echo "\n";
}
// sorteren op waarde
echo "\n";
asort($age);
foreach($age as $x => $x_value) {
    echo "Key=" . $x . ", Value=" . $x_value;
    echo "\n";
}

?>