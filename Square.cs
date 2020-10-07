using System;
using System.Collections.Generic;
using System.Text;

namespace HM_Geometry2
{
    public class Square : Figure
    {
        public double Side { get; private set; } = 0.0;

        public Square(double side)
        {
            Side = side;
        }

        public override double Perimeter()
        {
            return 4 * Side;
        }

        public override double Area()
        {
            return Side * Side;
        }
    }
}
