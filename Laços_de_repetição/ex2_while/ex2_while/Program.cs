using System;
using System.Globalization;

namespace ex2_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao = " ";

            while (opcao != "s")
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("Digite 'a' para ver informações do aluno");
                Console.WriteLine("Digite 'p' para ver informações do professor");
                Console.WriteLine("Digite 's' para encerrar");
                Console.Write("Escolha uma opção: ");

                opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "a":
                        Console.WriteLine("\nInformações do Aluno: Ryan, ADS, 4° Semestre.");
                        break;
                    case "p":
                        Console.WriteLine("\nInformações do Professor: Prof. Silva, Doutor em Computação.");
                        break;
                    case "s":
                        Console.WriteLine("\nEncerrando programa...");
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida. Tente novamente.");
                        break;  
                }
            }
        }
    }
}
