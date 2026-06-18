using System.Reflection.Metadata.Ecma335;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer?\n");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão\n");

            int operacao = int.Parse(Console.ReadLine());

            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (operacao)
            {
                case 1:
                    resultado = Adicao(num1, num2);
                    break;
                case 2:
                    resultado = Subtracao(num1, num2);
                    break;
                case 3:
                    resultado = Multiplicacao(num1, num2);  
                    break;
                case 4:
                    resultado = Divisao(num1, num2);
                    break;
                default:
                    Console.WriteLine("Número invalido");
                    break;
            }

            Console.WriteLine($"\nO resultado da operação é: {resultado}");
        }

        public static int Adicao(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        public static int Subtracao(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }

        public static int Multiplicacao(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }

        public static int Divisao(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }
    }
}
