using CompareTo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace CompareTo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um programa para comparar protutos por nome, usando a interface IComparable e o método CompareTo 

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            list.Sort(); // Ordena a lista usando o metodo CompareTo da classe Product

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}
