using System;
using System.Collections.Generic;
using System.Text;

namespace HM_Geometry2
{
    public class Triangle : Figure
    {
        public double Side1 { get; private set; } = 0.0;
        public double Side2 { get; private set; } = 0.0;
        public double Side3 { get; private set; } = 0.0;

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public override double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }

        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }
    }
}
