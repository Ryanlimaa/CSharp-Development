using System;
using System.Globalization;

namespace ex_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Digite sua senha: ");
            //int senha = int.Parse(Console.ReadLine());

            //int resultado = Ex1(senha);
            //Console.WriteLine(resultado);

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Digite o tipo de combustivel vc prefere:\n 1 = Alcool\n 2 = Gasolina\n 3 = Diesel\n 4 = Fim do parograma ");
            int tipo = int.Parse(Console.ReadLine());

            int resultado = Ex3(tipo, alcool, gasolina, diesel);
            Console.WriteLine(resultado);

        }

        static int Ex3(int tipo, int alcool, int gasolina, int diesel)
        {
            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool += 1;
                }
                else if (tipo == 2)
                {
                    gasolina += 1;
                }
                else if (tipo == 3)
                {
                    diesel += 1;
                }
                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

            return tipo;
        }

        static int Ex1(int senha)
        {
            int senhaCorreta = 2002;

            while (senha != senhaCorreta)
            {
                Console.WriteLine("Senha invalida!");
                Console.Write("Digite novamente: ");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Acesso Permitido!");

            return senha;

        }

    }
}