<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        $i = 1;

        do {
            echo $i, "<br>";
            $i++;
            if ($i == 10) continue;
            
        } while ($i < 21)
    ?>
</body>
</html>