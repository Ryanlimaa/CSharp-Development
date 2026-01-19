using System;
using System.Data;
using System.Globalization;

namespace ex_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int resultado = Ex1(x);
            Console.WriteLine(resultado);
        }

        static int Ex1(int x)
        {
            for (int i = 1; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            return x;
        }
    }
}