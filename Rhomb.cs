using System;
using System.Collections.Generic;
using System.Text;

namespace HM_Geometry2
{
    public class Rhomb : Figure
    {
        public double Diagonal1 { get; private set; } = 0.0;
        public double Diagonal2 { get; private set; } = 0.0;

        public Rhomb(double diagonal1, double diagonal2)
        {
            Diagonal1 = diagonal1;
            Diagonal2 = diagonal2;
        }

        public override double Perimeter()
        {
            return 4 * (Math.Sqrt(Math.Pow(Diagonal1 / 2, 2) + Math.Pow(Diagonal2 / 2, 2)));
        }

        public override double Area()
        {
            return Diagonal1 * Diagonal2 / 2;
        }
    }
}
