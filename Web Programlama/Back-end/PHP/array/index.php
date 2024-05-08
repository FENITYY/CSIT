<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $room = array("Efe"=>"3", "Yigit"=>"1", "Mehmet"=>"2");

        foreach ($room as $x => $y) {
            echo "$x : $y <br>";
        }
    ?>
</body>
</html>