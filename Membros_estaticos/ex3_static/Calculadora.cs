using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_static
{
    internal class Calculadora
    {
        public static double P = 3.14;
        public static double Circunferência(double r)
        {
            return 2 * P * r;
        }

        public static double Volume(double r)
        {
            return 4.0 / 3.0 * P * Math.Pow(r, 3);
        }
    }
}
