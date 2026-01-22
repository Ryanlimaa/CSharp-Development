using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 900.00, 10);

            //p.SetNome("TV 4K");
            //Console.WriteLine(p.GetNome());

            p.Nome = "TV 4K";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
        }
    }
}
