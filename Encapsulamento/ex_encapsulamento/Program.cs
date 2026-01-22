using System;
using System.Globalization;

namespace ex_poo_encap
{
    class Program
    {
        static void Main(string[] atgs)
        {
            Conta conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char temDeposito = char.Parse(Console.ReadLine());

            if (temDeposito == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta = new Conta(numero, titular, valorDeposito);
            }
            else
            {
                conta = new Conta(titular, numero);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}