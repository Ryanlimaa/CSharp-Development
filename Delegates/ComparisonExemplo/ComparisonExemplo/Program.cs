using ComparisonExemplo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ComparisonExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um programa para comparar protutos por nome, solução com função de comparação (CompareProduct)   

            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()); // Expressao lambda declarando uma função anonima para comparar os nomes dos produtos    
            list.Sort(comp);

            list.Sort(CompareProduct);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static int CompareProduct(Product p1, Product p2)
        {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()); // Comparando os nomes dos produtos, convertendo para maiúsculo com ToUpper para evitar problemas de comparação  
        }
    }
}
