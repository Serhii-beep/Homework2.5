using System;
using System.Collections.Generic;
using System.Text;

namespace HM_Geometry2
{
    public class Circle : Figure
    {
        public double Radius { get; private set; } = 0.0;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
