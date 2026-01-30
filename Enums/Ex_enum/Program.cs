using System;
using System.Globalization;
using Ex_enum.Entities.Enums;
using Ex_enum.Entities;

namespace Ex_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o nome do Departamento: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Entre com os dados do trabalhador: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Entre com o salario base: ");
            double baseSalario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalario, dept);

            Console.Write("Quantos contratos serão cadastrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Entre com os dados do {i}° Contrato: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duração (horas): ");
                int horas = int.Parse(Console.ReadLine());

                HourContract contato = new HourContract(data, valorHora, horas);

                worker.AddContract(contato);
            }
            Console.WriteLine();

            Console.WriteLine("Entre com o mes e o ano para calcular o ganho (MM/YYYY): ");
            Console.Write("Mes: ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Ano: ");
            int ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Nome: " + worker.Name);
            Console.WriteLine("Departamento: " + worker.Departament.Name);
            Console.WriteLine($"Ganhos de {mes}/{ano}: " + worker.Income(ano, mes));
        }
    }
}
