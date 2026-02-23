using System;
using System.Collections.Generic;
using DelegateAction.Entities;

namespace DelegateAction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            Action<Product> act = UpdatePrice;

            list.ForEach(act);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        // Função que nao retorna nada e recebe um produto e atualiza o preço  
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}