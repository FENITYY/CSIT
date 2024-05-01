<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php 
        $x = 10;
        function scope(){
            $x = 5;
            echo "Variable Inside : " . $x . "<br>";
        }
        scope() . "<br>";
        echo "Variable Outside : " . $x . "<br>";
    ?>
</body>
</html>