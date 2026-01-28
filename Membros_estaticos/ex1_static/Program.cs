using System;
using System.Globalization;

namespace ex1_static
{
    class Program
    {
        static double P = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferência(raio);
            double vol = Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + P);
        }

        static double Circunferência(double r)
        {
            return 2 * P * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * P * Math.Pow(r, 3);
        }
    }
}