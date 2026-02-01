using System;
using System.Globalization;
using System.Collections.Generic;
using ex01_H.P.Entities;

namespace ex01_H.P
{
    class Program
    {
        /*Uma empresa possui funcionários próprios e terceirizados.
        Para cada funcionário, deseja-se registrar nome, horas
        trabalhadas e valor por hora.Funcionários terceirizados
        possuem ainda uma despesa adicional.
        O pagamento dos funcionários corresponde ao valor da hora
        multiplicado pelas horas trabalhadas, sendo que os
        funcionários terceirizados ainda recebem um bônus
        correspondente a 110% de sua despesa adicional.
        Fazer um programa para ler os dados de N funcionários (N
        fornecido pelo usuário) e armazená-los em uma lista.Depois
        de ler todos os dados, mostrar nome e pagamento de cada
        funcionário na mesma ordem em que foram digitados.*/

        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.Write("Entre com o numero de funcionarios: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do {i}° Funcionario: ");
                Console.Write("Tercerizado (s/n)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string name = Console.ReadLine();

                Console.Write("Horas trabalhadas: ");
                int hours = int.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valorPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 's' || ch == 'S')
                {
                    Console.Write("Despesa adicional: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valorPerHour, additionalCharge)); // introduzindo o polimorfismo para usar uma variavel do tipo base para referenciar uma objeto da classe derivada
                }
                else
                {
                    list.Add(new Employee(name, hours, valorPerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("PAGAMENTOS:");

            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
