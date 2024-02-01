using System;
using System.Globalization;
using Exercicio3;

namespace EnumerationAndComposition {
    internal class Exercicio3 {
        static void Main(string[] args) {
            Order order;

            System.Console.WriteLine("Enter client data: ");
            System.Console.Write("Name: ");
            string clientName = Console.ReadLine();
            System.Console.Write("Email: ");
            string clientEmail = Console.ReadLine();
            System.Console.Write("Birth date: ");
            DateTime clientBirth = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Client client = new Client(clientName, clientEmail, clientBirth);


            System.Console.WriteLine();

            System.Console.WriteLine("Enter order data: ");
            System.Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine().ToUpper());
            System.Console.Write("How many item to this order? ");
            

            order = new Order(status, client);
            int itemsPerOrder = int.Parse(Console.ReadLine());
            for(int i = 0; i < itemsPerOrder; i++) {
                System.Console.WriteLine($"Enter #{i+1} item data: ");
                System.Console.Write("Product name: ");
                string productName = Console.ReadLine();
                System.Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);

                System.Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(quantity, product);

                order.AddItem(orderItem);
            }

            System.Console.WriteLine();
            System.Console.WriteLine();

            System.Console.WriteLine(order);
        }
    }
}