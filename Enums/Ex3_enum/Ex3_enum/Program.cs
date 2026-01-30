using System;
using System.Globalization;
using Ex3_enum.Entitis;
using Ex3_enum.Entitis.Enums;

namespace Ex3_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente:");
            Console.Write("Nome: ");
            string clientName = Console.ReadLine();

            Console.Write("Email: ");
            string clientEmail = Console.ReadLine();

            Console.Write("Data de nascimento (DD/MM/YYYY): ");
            DateTime brithDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Entre com os dados do pedido:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(clientName, clientEmail, brithDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("Quantos itens terão no pedido? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i ++)
            {
                Console.WriteLine($"Entre com os dados do {i} item:");
                Console.Write("Nome do produdo: ");
                string productName = Console.ReadLine();

                Console.Write("Preço do produto: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, productPrice);

                Console.Write("Quantidade: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, productPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}