<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        function sum_of_squares($x ,$y){
            $z = ($x * $x) + ($y * $y);
            return $z;
        }

        echo sum_of_squares(100, 521);
    ?>
</body>
</html>