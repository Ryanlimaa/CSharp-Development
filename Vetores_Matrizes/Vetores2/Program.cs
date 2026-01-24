using System;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace Vetores2
{
    class Program
    {
        static void Main(string[] atgs)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] vet = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vet[i] = new Produto(nome, preco);
            }

            double somatorio = 0.0;

            for (int i = 0; i < n; i++)
            {
                somatorio += vet[i].Preco;
            }

            double media = somatorio / n;

            Console.WriteLine("A media dos preços dos produtos é: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}