<!DOCTYPE html>
<html>
<body>

<?php
function staticTest() {
  static $x = 0; /* Degisken degeri arttiginda arrtmis degeri tutar */
  echo $x;
  $x++;
}

function nonStaticTest() {
    $x = 0; /* Degisken degeri arttiginda arrtmis degeri tutar */
    echo $x;
    $x++;
  }

staticTest();
echo "<br>";
staticTest();
echo "<br>";
staticTest();
echo "<br>";

echo "<br>";

nonStaticTest();
echo "<br>";
nonStaticTest();
echo "<br>";
nonStaticTest();
?> 

</body>
</html>
