<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        @keyframes fade-in {
            0% { opacity: 0; }
            100% { opacity: 1; }
        }

        .fade-in-item {
            animation: fade-in 1s ease-in-out;
        }
    </style>
</head>
<body>
    <?php 
        $x = $y = $z = "KARSTERR";
        echo $x. "<br>"; /* string bilestirmesi "." ile saglaniyor.*/
        echo $y. "<br>";
        echo $z. "<br>";
    ?>

    <div class="container">
        <ul class="list-group">
            <?php
            $items = ["Elma", "Armut", "Karpuz"];
            foreach ($items as $item) {
                echo "<li class='list-group-item fade-in-item'>$item</li>";
            }
            ?>
        </ul>
    </div>

</body>
</html>