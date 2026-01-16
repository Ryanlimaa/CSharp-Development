using System;
using System.Globalization;

namespace ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor para a variavel A: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para a variavel B: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para a variavel C: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para a variavel D: ");
            int d = int.Parse(Console.ReadLine());

            int direfenca = (a * b - c * d);
            Console.WriteLine(direfenca);
        }
    }
}