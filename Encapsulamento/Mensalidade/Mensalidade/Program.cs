using Mensalidade.Entities;
using System;
using System.Globalization;

namespace Mensalidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            a.ID = 1;
            Console.Write("Digite seu nome: ");
            a.Nome = Console.ReadLine();

            Console.Write("Digite sua idade: ");
            a.Idade = int.Parse(Console.ReadLine());

            Console.Write("Digite sua mensalidade: ");
            a.Mensalidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double novaMens = a.CalcularMensalidade(10);

            Console.WriteLine("-----------------------------------");
            Console.WriteLine(a.ToString());
            Console.WriteLine("Mensalidade com desconto: " + novaMens);
        }
    }
}
