using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Digite seu peso:");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite sua altura");
        double altura = double.Parse(Console.ReadLine());

        double IMC = peso / (altura * altura);

        Console.WriteLine("Seu IMC é: " + Math.Round(IMC, 2));

    }
}