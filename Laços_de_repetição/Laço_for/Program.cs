using System;
using System.Globalization;

namespace Laço_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros inteiros voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int somatorio = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                somatorio += valor;
            }

            Console.WriteLine("Soma = " + somatorio);
        }
    }
}