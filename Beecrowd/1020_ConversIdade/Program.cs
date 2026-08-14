using System;

class Program
{
    /*
        Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias
        Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação que permite 12 meses e alguns dias, como 360, 363 ou 364. Este é apenas um exercício com objetivo de testar raciocínio matemático simples.
        Entrada:
        O arquivo de entrada contém um valor inteiro.
    */
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int ano = n / 365;
        int resto = n % 365;

        int mes = resto / 30;
        int dia = resto % 30;

        System.Console.WriteLine($"{ano} ano(s)");
        System.Console.WriteLine($"{mes} mes(es)");
        System.Console.WriteLine($"{dia} dia(s)");
    }
}