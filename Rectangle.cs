using System;
using System.Collections.Generic;
using System.Text;

namespace HM_Geometry2
{
    public class Rectangle : Figure
    {
        public double Side1 { get; private set; } = 0.0;
        public double Side2 { get; private set; } = 0.0;

        public Rectangle(double side1, double side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        public override double Perimeter()
        {
            return 2*(Side1 + Side2);
        }

        public override double Area()
        {
            return Side1 * Side2;
        }
    }
}
