namespace Exercicio2;

public class ImportedProducts : Product
{
    public double CustomsFees { get; set;}
    public ImportedProducts(string name, double price, double customsFee) 
        : base(name, price)
    {
        CustomsFees = customsFee;
    }

    public double TotalPrice() {
        return Price + CustomsFees;
    }

    public override string PriceTag()
    {
        return $"{Name} $ {TotalPrice()} (Customs fee: $ {CustomsFees})";
    }
}
