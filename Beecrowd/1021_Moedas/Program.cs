using System;
using System.Globalization;

class Program
{
    /*
        Leia um valor de ponto flutuante com duas casas decimais. Este valor representa um valor monetário. A seguir, calcule o menor número de notas e moedas possíveis no qual o valor pode ser decomposto. As notas consideradas são de 100, 50, 20, 10, 5, 2. As moedas possíveis são de 1, 0.50, 0.25, 0.10, 0.05 e 0.01. A seguir mostre a relação de notas necessárias.
        Entrada:
        O arquivo de entrada contém um valor de ponto flutuante N (0 ≤ N ≤ 1000000.00).
        Saída:
        Imprima a quantidade mínima de notas e moedas necessárias para trocar o valor inicial, conforme exemplo fornecido.
        Obs: Utilize ponto (.) para separar a parte decimal.
    */
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        int centavos = (int)Math.Round(n * 100);

        Console.WriteLine("NOTAS:");
        Console.WriteLine($"{centavos / 10000} nota(s) de R$ 100.00");
        centavos %= 10000;

        Console.WriteLine($"{centavos / 5000} nota(s) de R$ 50.00");
        centavos %= 5000;

        Console.WriteLine($"{centavos / 2000} nota(s) de R$ 20.00");
        centavos %= 2000;

        Console.WriteLine($"{centavos / 1000} nota(s) de R$ 10.00");
        centavos %= 1000;

        Console.WriteLine($"{centavos / 500} nota(s) de R$ 5.00");
        centavos %= 500;

        Console.WriteLine($"{centavos / 200} nota(s) de R$ 2.00");
        centavos %= 200;

        Console.WriteLine("MOEDAS:");
        Console.WriteLine($"{centavos / 100} moeda(s) de R$ 1.00");
        centavos %= 100;

        Console.WriteLine($"{centavos / 50} moeda(s) de R$ 0.50");
        centavos %= 50;

        Console.WriteLine($"{centavos / 25} moeda(s) de R$ 0.25");
        centavos %= 25;

        Console.WriteLine($"{centavos / 10} moeda(s) de R$ 0.10");
        centavos %= 10;

        Console.WriteLine($"{centavos / 5} moeda(s) de R$ 0.05");
        centavos %= 5;

        Console.WriteLine($"{centavos / 1} moeda(s) de R$ 0.01");
    }
}
