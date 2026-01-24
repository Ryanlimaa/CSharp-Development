using System;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace Vetores1
{
    class Program
    {
        static void Main(string[] atgs)
        {
            Console.WriteLine("Digite a quantidade de alturas que deseja para obter uma media: ");
            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.WriteLine();

            double somatorio = 0.0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vet[i].ToString("F2", CultureInfo.InvariantCulture));
                somatorio += vet[i];
            }

            double media = somatorio / n;
            Console.WriteLine("A media de alturas é: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}