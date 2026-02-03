using System;
using System.Globalization;
using System.Collections.Generic;
using Exemplo_try_catch.Entities;
using Exemplo_try_catch.Entities.Exceptions;


namespace Exemplo_try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler os dados de uma reserva de hotel (número do quarto, data
            de entrada e data de saída) e mostrar os dados da reserva, inclusive sua duração em
            dias. Em seguida, ler novas datas de entrada e saída, atualizar a reserva, e mostrar
            novamente a reserva com os dados atualizados. O programa não deve aceitar dados
            inválidos para a reserva, conforme as seguintes regras:
            - Alterações de reserva só podem ocorrer para datas futuras
            - A data de saída deve ser maior que a data de entrada*/
            try
            {
                Console.Write("Numero do quarto: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Data de check-in (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());

                Console.Write("Data de check-out (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(number, checkIn, checkOut);
                Console.WriteLine("Reserva: " + reservation);

                Console.WriteLine();
                Console.WriteLine("Digite os dados para atualizar a reserva:");
                Console.Write("Data de check-in (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de check-out (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reserva: " + reservation);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error in format: " + e.Message);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }

    }

}
