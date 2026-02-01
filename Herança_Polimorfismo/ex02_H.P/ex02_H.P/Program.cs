using System;
using System.Globalization;
using System.Collections.Generic;
using ex02_H.P.Entities;

namespace ex02_H.P
{
    class Program
    {
        /* Fazer um programa para ler os dados de N
        produtos (N fornecido pelo usuário). Ao final,
        mostrar a etiqueta de preço de cada produto na
        mesma ordem em que foram digitados.
        Todo produto possui nome e preço. Produtos
        importados possuem uma taxa de alfândega, e
        produtos usados possuem data de fabricação.
        Estes dados específicos devem ser
        acrescentados na etiqueta de preço conforme
        exemplo (próxima página). Para produtos
        importados, a taxa e alfândega deve ser
        acrescentada ao preço final do produto.*/
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Entre com o numero de produtos:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do {i}° Produto:");

                Console.Write("Comum, Usado ou Importado (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Preço: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'c' || ch == 'C')
                {
                    list.Add(new Product(name, price));
                }
                else if (ch == 'u' || ch == 'U')
                {
                    Console.Write("Data de fabricação (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (ch == 'i' || ch == 'I')
                {
                    Console.Write("Taxa alfandegária: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PREÇO DOS PRODUTOS:");

            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
        }
    }
}