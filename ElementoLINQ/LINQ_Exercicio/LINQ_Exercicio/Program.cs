using System;
using System.Collections.Generic;
using System.Globalization;
using LINQ_Exercicio.Entities;
using System.IO;
using System.Linq;

namespace LINQ_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Fazer um programa para ler um conjunto de produtos a partir de um
            arquivo em formato .csv (suponha que exista pelo menos um produto).
            Em seguida mostrar o preço médio dos produtos. Depois, mostrar os
            nomes, em ordem decrescente, dos produtos que possuem preço
            inferior ao preço médio.
            */

            Console.Write("Entre com o caminho do arquivo: ");
            string path = Console.ReadLine();

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string lines = sr.ReadLine();
                    Console.WriteLine(lines);
                }
            }
            Console.WriteLine();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average(); // Pegando a media dos preços com Average
            Console.WriteLine("Media do preços: " + avg.ToString("F2", CultureInfo.InvariantCulture));

            //var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            var names =
                from p in list
                where p.Price < avg
                orderby p.Name descending
                select p.Name;
            foreach (var result in names)
            {
                Console.WriteLine(result);
            }
        }
    }
}