namespace Exercicio3;

public abstract class TaxPayers
{
    public string Name { get; set; }
    public double AnualIncome { get; set; }

    public TaxPayers(string name, double anualIncome) {
        Name = name;
        AnualIncome = anualIncome;
    }

    public abstract double TaxesPaid();
}
