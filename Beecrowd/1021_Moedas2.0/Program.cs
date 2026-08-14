using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        double valor = double.Parse(Console.ReadLine());

        int centavos = (int)Math.Round(valor * 100);

        // Valores das notas e moedas representados em centavos
        int[] notas = { 10000, 5000, 2000, 1000, 500, 200 };
        int[] moedas = { 100, 50, 25, 10, 5, 1 };

        Console.WriteLine("NOTAS:");
        foreach (int nota in notas)
        {
            int qtdNotas = centavos / nota;
            Console.WriteLine($"{qtdNotas} nota(s) de R$ {(nota / 100.0):F2}");
            centavos %= nota; // Atualiza o saldo restante de centavos
        }

        Console.WriteLine("MOEDAS:");
        foreach (int moeda in moedas)
        {
            int qtdMoedas = centavos / moeda;
            Console.WriteLine($"{qtdMoedas} moeda(s) de R$ {(moeda / 100.0):F2}");
            centavos %= moeda; // Atualiza o saldo restante de centavos
        }
    }
}