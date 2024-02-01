namespace Exercicio3;

public class Product
{
    public string Name { get; set; }
    public double Price { get; }

    public Product(string name, double price) {
        Name = name;
        Price = price;
    }
}
