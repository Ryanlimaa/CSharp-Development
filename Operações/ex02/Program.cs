using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            Console.WriteLine("Digite o valor do raio para saber o valor da area do circulo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = pi * Math.Pow(raio, 2.0);

            Console.WriteLine("A= " + area.ToString("f4", CultureInfo.InvariantCulture));
        }
    }
}