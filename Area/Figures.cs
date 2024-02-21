using System;

namespace Areas
{
    public class Circle
    {
        private double _radius { get; set; }

        public Circle(double radius)
        {
            _radius = radius;
        }
        public double Area() => Math.Round(Math.PI * Math.Pow(_radius, 2), 4);
    }

    public class Triangle
    {
        private double _aSide { get; set; }
        private double _bSide { get; set; }
        private double _cSide { get; set; }

        public Triangle(double a, double b, double c)
        {
            _aSide = a;
            _bSide = b;
            _cSide = c;
        }

        public double Area()
        {
            if (Pifagor()) return Math.Round(_aSide * _bSide * 0.5, 4); // Проверка является ли треугольник прямоугольным
            else
            {
                double semiPerimeter = (_aSide + _bSide + _cSide) / 2;
                return Math.Round(Math.Sqrt(semiPerimeter * (semiPerimeter - _aSide)
                    * (semiPerimeter - _bSide) * (semiPerimeter - _cSide)), 4);
            }
        }

        // Теорема Пифагора
        private bool Pifagor() => Math.Pow(_aSide, 2) + Math.Pow(_bSide, 2) == Math.Pow(_cSide, 2);
    }

    public class Square
    {
        private double _side { get; set; }

        public Square(double side)
        {
            _side = side;
        }

        public double Area() => Math.Round(Math.Pow(_side, 2), 4);
    }

    public class Rectangle
    {
        private double _aSide {  get; set; }
        private double _bSide {  get; set; }

        public Rectangle(double a, double b)
        {
            _aSide = a;
            _bSide = b;
        }

        public double Area() => Math.Round(_aSide * _bSide, 4);
    }

    public class Parallelogram
    {
        private double _aSide { get; set; }
        private double _bSide { get; set; }
        private double _height { get; set; }
        private double _angle { get; set; }

        public Parallelogram(double a, double height)
        {
            _aSide = a;
            _height = height;
        }

        public Parallelogram(double a, double b, double angle)
        {
            _aSide = a;
            _bSide = b;
            _angle = (angle * Math.PI) / 180; // Перевод радиан в градусы
        }

        public double Area()
        {
            if (_angle == 0)
                return Math.Round(_aSide * _height, 4);
            else
                return Math.Round(_aSide * _bSide * Math.Sin(_angle), 4);
        }
    }

    public class Quadrangle
    {
        private double _aDiagonal { get; set; }
        private double _bDiagonal { get; set; }
        private double _angle { get; set; }

        public Quadrangle(double a, double b, double angle)
        {
            _aDiagonal = a;
            _bDiagonal = b;
            _angle = (angle * Math.PI) / 180; // Перевод радиан в градусы
        }

        public double Area() => Math.Round((0.5 * _aDiagonal * _bDiagonal) * Math.Sin(_angle), 4);
    }

    public class Rhombus
    {
        private double _aSide { get; set; }
        private double _angle { get; set; }
        private double _aDiagonal { get; set; }
        private double _bDiagonal { get; set; }

        public Rhombus() { }

        public Rhombus(double a, double angle)
        {
            _aSide = a;
            _angle = (angle * Math.PI) / 180; // Перевод радиан в градусы
        }

        public void SetDiagonales(double a, double b)
        {
            _aDiagonal = a;
            _bDiagonal = b;
        }

        public double Area()
        {
            if (_angle != 0)
                return Math.Round(Math.Pow(_aSide, 2) * Math.Sin(_angle), 4);
            else
                return Math.Round((_aDiagonal * _bDiagonal) / 2, 4);
        }
    }
}
