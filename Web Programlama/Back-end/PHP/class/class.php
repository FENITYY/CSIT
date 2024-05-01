<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    class Car {
        public $brand;
        public $model;
        public $year;
        public $color;
    }

    $car1 = new Car();
    $car1->brand = "Toyota";
    $car1->model = "Camry";
    $car1->year = 2022;
    $car1->color = "Red";

    $car2 = new Car();
    $car2->brand = "Volvo";
    $car2->model = "S40";
    $car2->year = 2001;
    $car2->color = "Brown";

    var_dump($car1);
    var_dump($car2);
    ?>
</body>
</html>