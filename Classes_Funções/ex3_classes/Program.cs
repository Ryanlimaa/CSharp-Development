using System;
using System.Globalization;

namespace ex3_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Produto p = new Produto("TV", 900.00, 2);

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço : ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque : ");
            p.Quantidade = int.Parse(Console.ReadLine());*/

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço : ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Para o construtor de quantidade fixa eu retiro a variavel quantidade instanciada
            Console.Write("Quantidade no estoque : ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            // outra forma de instanciar produtos
            /*Produto p2 = new Produto
            {
                Nome = "TV",
                Preco = 900.00,
                Quantidade = 5
            };*/

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser adicionados no estoque : ");
            int add = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(add);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removidos do estoque : ");
            int rmv = int.Parse(Console.ReadLine());
            p.RemoverProdutos(rmv);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}