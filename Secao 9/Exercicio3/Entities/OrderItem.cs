namespace Exercicio3;

public class OrderItem
{
    public int Quantity { get; set; }
    public double Price { get; set; }
    public Product Product { get; set; }

    public OrderItem(int quantity, Product product) {
        Quantity = quantity;
        Product = product;
        Price = Product.Price;
    }

    public double Subtotal() {
        return Quantity * Price;
    }

    public override string ToString()
    {
        return $"{Product.Name}, ${Price}, Quantity: {Quantity}, Subtotal: {Subtotal()}";
    }
}
