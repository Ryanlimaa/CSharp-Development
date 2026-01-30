using Enums.Entities;
using System;
using System.Globalization;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Convertendo tipos enumerados para string
            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //Ao contrario
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
            Console.WriteLine(os);
        }
    }
}