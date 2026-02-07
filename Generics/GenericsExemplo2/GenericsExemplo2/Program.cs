using System;
using System.Globalization;
using System.Collections.Generic;
using GenericsExemplo2.Entities;
using GenericsExemplo2.Services;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Uma empresa de consultoria deseja avaliar a performance de produtos,
            funcionários, dentre outras coisas. Um dos cálculos que ela precisa é encontrar
            o maior dentre um conjunto de elementos. Fazer um programa que leia um
            conjunto de N produtos, conforme exemplo, e depois mostre o mais caro deles*/

            List<Product> list = new List<Product>();

            Console.Write("Entre com o numero de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
                list.Add(new Product(vect[0], price));
            }

            CalculationService calculationService = new CalculationService();

            Product p = calculationService.Max(list); // <Product> opcional

            Console.WriteLine("Produto mais caro:");
            Console.WriteLine(p);
        }
    }
}