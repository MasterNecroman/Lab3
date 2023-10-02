using System;

namespace Task_1
{
    class Rectangle
    {
        public double Area { get; private set; }
        public double Perimeter { get; private set; }

        private double side1;
        private double side2;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;

            CalculateArea();
            CalculatePerimeter();
        }

        private void CalculateArea()
        {
            Area = side1 * side2;
        }

        private void CalculatePerimeter()
        {
            Perimeter = 2 * (side1 + side2);
        }
    }
}