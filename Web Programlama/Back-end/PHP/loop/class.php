<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <style>
        * {
            background-color: sandybrown;
        }
    </style>
    <title>Document</title>
</head>
<body>
    <?php
        class Car {
            public $color;
            public $model;
            public $year;

            public function __construct($color, $model, $year) {
                $this->color = $color;
                $this->model = $model;
                $this->year = $year;
            }

            public function get_car(){
                echo "Model : {$this->model}, Color : {$this->color}, Year : {$this->year}<br>";
            }
        }

        $myCar1 = new Car("beige", "Volvo S40", "2001");
        $myCar2 = new Car("silver", "Tofas Sahin", "2000");
        $myCar3 = new Car("white", "Fiat Doblo", "2016");

        $myCar1->get_car();
        $myCar2->get_car();
        $myCar3->get_car();
    ?>
</body>
</html>