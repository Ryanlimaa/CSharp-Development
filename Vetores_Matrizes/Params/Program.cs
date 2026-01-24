using System;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace Params
{
    class Program
    {
        static void Main(string[] atgs)
        {
            int soma = Calculator.Sum(3, 5);
            Console.WriteLine(soma);

            int a = 10;
            Calculator.Triples(ref a);
            Console.WriteLine(a);

            int b = 5;
            int triple;
            Calculator.Triple(b, out triple);
            Console.WriteLine(triple);
        }
    }
}