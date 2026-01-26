using System;
using System.Globalization;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            // switch é mais recomendado usar quando voce tem multiplas condicoes, se usa ele quando a condição envolve
            // o teste do valor de uma variavel e para seu codigo nao ficar cheio de if e else if,
            // porem ele so realiza condicoes de igualdade nao podendo trabalhar com operadores aritimeticos
            // case = if
            // default = else

            int x = int.Parse(Console.ReadLine());

            string day;

            switch (x)
            {
                case 1:
                    day = "Domingo";
                    break;
                case 2:
                    day = "Segunda";
                    break;
                case 3:
                    day = "Terça";
                    break;
                case 4:
                    day = "Quarta";
                    break;
                case 5:
                    day = "Quinta";
                    break;
                case 6:
                    day = "Sexta";
                    break;
                case 7:
                    day = "Sabado";
                    break;
                default:
                    day = "Dia inexixtente!";
                    break;
            }

            Console.WriteLine("Dia: " + day);
        }
    }
}