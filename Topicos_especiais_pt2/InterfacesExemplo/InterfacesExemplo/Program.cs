using InterfacesExemplo.Entities;
using InterfacesExemplo.Services;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace InterfacesExemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel:");
            Console.Write("Modelo do carro: ");
            string model = Console.ReadLine();

            Console.Write("Horário de entrada (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Horário de saída (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            Console.Write("Entre com o preço por hora: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Entre com o preço por dia: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxServices());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("FATURA:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}