using System.Runtime.CompilerServices;
using System.Text;

namespace Exercicio3;

public class Order
{
    private DateTime Moment = DateTime.Now;
    public OrderStatus Status;

    private List<OrderItem> items = new List<OrderItem>();
    private Client Client;

    public Order(OrderStatus status, Client client) {
        Status = status;
        Client = client;
    }

    public void AddItem(OrderItem orderItem) {
        items.Add(orderItem);
    }

    public void RemoveItem(OrderItem orderItem) {
        items.Remove(orderItem);
    }

    public double Total() {
        double total = 0;
        foreach(OrderItem i in items) {
            total += i.Subtotal();
        }
        return total;
    }


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("ORDER SUMMARY");
        sb.AppendLine("Order moment: " + Moment);
        sb.AppendLine("Order status: " + Status);
        sb.AppendLine("Client: " + Client);
        foreach(OrderItem orderItem in items) {
            sb.AppendLine(orderItem.ToString());
        }

        sb.AppendLine("Total price: " + Total());
        return sb.ToString();
    }
}
