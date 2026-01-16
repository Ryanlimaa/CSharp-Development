using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o codigo, a quantidade e o valor da primeira peça tudo na mesma linha: ");
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            double quant = double.Parse(vet[1]);
            double valor = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o codigo, a quantidade e o valor da segunda peça tudo na mesma linha: ");
            string[] vet2 = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(vet2[0]);
            double quant2 = double.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double valorTotal1 = quant * valor;
            double valorTotal2 = quant2 * valor2;
            double pagar = valorTotal1 + valorTotal2;

            Console.WriteLine("VALOR A PAGAR: " + pagar.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
