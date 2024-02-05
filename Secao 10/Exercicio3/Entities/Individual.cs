namespace Exercicio3;

public class Individual : TaxPayers
{
    public double HealthExp { get; set; }
    public Individual(string name, double anualIncome, double healthExp)
        : base(name, anualIncome)
    {
        HealthExp = healthExp;
    }

    public override double TaxesPaid()
    {
        double taxes = 0;
        if(AnualIncome < 20000.00) {
            taxes += AnualIncome * 0.15;
        } else {
            taxes += AnualIncome * 0.25;
        }

        return taxes - (HealthExp * 0.5);
    }
}
