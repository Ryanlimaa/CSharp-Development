using System;
using System.Globalization;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = new string[] { "Alex", "Maria", "Bob"};

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }
            Console.WriteLine("--------------------------------------");

            foreach (string obj in vet)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
