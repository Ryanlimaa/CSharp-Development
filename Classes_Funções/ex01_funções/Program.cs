using System;

class Program
{
    static void Main(string[] args)
    {
        ExibirMsg();
        GerarPreco(60.00 , "Carregador");
    }

    static void ExibirMsg()
    {
        System.Console.WriteLine("É assim que se faz uma funcao!");
    }

    static void GerarPreco(double preco, string nome)
    {
        System.Console.WriteLine("Nome do produto: " + nome);
        System.Console.WriteLine("Preço : R$" + preco);
    }
}
