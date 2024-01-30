using System;

namespace EnumerationAndComposition {
    internal class Enums {

        static void Main(string[] args) {
            Order order = new Order { 
                Id = 1, 
                Moment = DateTime.Now, 
                Status = OrderStatus.Processing
            };

            Console.WriteLine(order);

            OrderStatus orderStatus = Enum.Parse<OrderStatus>("Delivered");
            System.Console.WriteLine(orderStatus);
        }
    }
}