using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu numero: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu numero de horas trabalhadas: ");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor que recebe por horas: ");
            double recebe = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salario = horas * recebe;

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = " + salario.ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}
