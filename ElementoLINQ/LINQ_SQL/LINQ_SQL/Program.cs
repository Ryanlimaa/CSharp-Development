using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using LINQ_SQL.Entities;

namespace LINQ_SQL
{
    class Program
    {
        static void Print<T>(string mensagem, IEnumerable<T> collection)
        {
            Console.WriteLine(mensagem);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Ferramentas", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computadores", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronicos", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computador", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Martelo", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Serrote", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Impressora", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Barra de som", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Nivel", Price = 70.0, Category = c1 }
            };

            // Sintaxe similar ao SQL

            //var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            var r1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900.0
                select p;
            Print("TIER 1 E OOM PREÇO < 900.00: ", r1);

            //var r2 = products.Where(p => p.Category.Tier == 2).Select(p => p.Name);
            var r2 =
                from p in products
                where p.Category.Tier == 2
                select p.Name; 
            Print("NOMES DOS PRODUTOS DA CATEGORIA FERRAMENTAS: ", r2);

            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new { p.Name, p.Price, CategoryName = p.Category.Name };
            Print("NOMES COMEÇADOS COM 'C', SEUS PREÇOS E CATEGORIAS: ", r3);

            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Name
                orderby p.Price
                select p;
            Print("TIER 1 ORDENADOS POR PREÇO E NOME", r4);

            //var r5 = r4.Skip(2).Take(4);
            var r5 =
                (from p in r4
                 select p).Skip(2).Take(4);
            Print("TIER 1 ORDENADOS POR PREÇO E NOME SKIP 2 TAKE 4", r5);

            //var r6 = products.First();
            var r6 = (from p in products select p).First();
            Console.WriteLine("Primeiro Produto: " + r6);

            //var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            var r7 =
                (from p in products
                 where p.Price > 3000.0
                 select p).FirstOrDefault();
            Console.WriteLine("First or default: " + r7);
            Console.WriteLine();

            //var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            var r8 =
                (from p in products
                 where p.Id == 3
                 select p).SingleOrDefault();
            Console.WriteLine("Single or default test1: " + r8);

            //var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
            var r9 =
                (from p in products
                 where p.Id == 30
                 select p).SingleOrDefault();
            Console.WriteLine("Single or default test2: " + r9);
            Console.WriteLine();

            //var r10 = products.GroupBy(p => p.Category);
            var r10 =
                from p in products
                group p by p.Category;
            foreach (IGrouping<Category, Product> group in r10)
            {
                Console.WriteLine("Categoria " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }
        }
    }
}
