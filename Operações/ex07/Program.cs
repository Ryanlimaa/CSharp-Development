using System;

class Program
{
    static void Main(string[] args)
    {

        const double precoDuzia = 14.99;

        Console.WriteLine("Digite uma quantidade de laranjas");
        int quantidadeLaran = int.Parse(Console.ReadLine());

        double duzias = quantidadeLaran / 12;
        double resto = quantidadeLaran % 12;

        double precoFinal = (precoDuzia * duzias) + ((resto / 12) * precoDuzia);

        Console.WriteLine("O preco final é: " + Math.Round(precoFinal, 2));
    }
}