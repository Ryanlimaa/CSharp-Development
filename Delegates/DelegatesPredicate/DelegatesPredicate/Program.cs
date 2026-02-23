using DelegatesPredicate.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace DelegatesPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Predicate é um delegate, uma referencia para uma função que recebe um argumento e retorna um valor booleano. 
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.RemoveAll(PriceTest);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        public static bool PriceTest(Product p)
        {
            return p.Price >= 100.00;
        }
    }
}

