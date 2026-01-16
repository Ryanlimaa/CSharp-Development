using System;
using System.Globalization;

namespace Entrada_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] vet = Console.ReadLine().Split(' ');// Split te permite digitar palavras separadamente e armazenar em um vetor de strings
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine();
            Console.WriteLine("Voce digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }  
}
