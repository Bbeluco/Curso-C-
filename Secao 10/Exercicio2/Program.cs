using System;
using System.Globalization;
using Exercicio2;

namespace InheritanceAndPolimorphism {
    internal class Exercicio2 {
        static void Main(string[] args) {
            System.Console.Write("Enter a number of products: ");
            int nProduct = int.Parse(Console.ReadLine());

            List<Product> products = new List<Product>();
            for(int i = 1; i <= nProduct; ++i) {
                System.Console.WriteLine($"Product #{i} data: ");
                System.Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());
                if(type == 'i') {
                    System.Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProducts(name, price, customFee));
                } else if(type == 'u') {
                    System.Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    products.Add(new UsedProduct(name, price, date));
                } else {
                    products.Add(new Product(name, price));
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("PRICE TAGS: ");
            for(int i = 0; i < nProduct; ++i) {
                System.Console.WriteLine(products[i].PriceTag());
            }
        }
    }
}