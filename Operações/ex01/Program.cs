using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois valores para efetuar a soma: ");
            int val1 = int.Parse(Console.ReadLine());
            int val2 = int.Parse(Console.ReadLine());

            int soma = val1 + val2;

            Console.WriteLine(" SOMA = " + soma);
        }
    }
}