using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_static
{
    internal class Calculadora
    {
        public double P = 3.14;
        public double Circunferência(double r)
        {
            return 2 * P * r;
        }

        public double Volume(double r)
        {
            return 4.0 / 3.0 * P * Math.Pow(r, 3);
        }
    }
}
