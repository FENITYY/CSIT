<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    $x = "Bu bir \$GLOBALS degiskenidir";
    $y = "Bu da global bir baska degisken";

    function test(){
        echo $GLOBALS['x'];
        echo "<br>";
        global $y;
        echo $y;
    }

    test()
    ?>
</body>
</html>