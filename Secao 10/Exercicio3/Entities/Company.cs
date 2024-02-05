namespace Exercicio3;

public class Company : TaxPayers
{
    public int NumberEmployees { get; set; }
    public Company(string name, double anualIncome, int numberEmployees)
        : base(name, anualIncome)
    {
        NumberEmployees = numberEmployees;
    }

    public override double TaxesPaid()
    {
        if(NumberEmployees > 10) {
            return AnualIncome * 0.14;
        } else {
            return AnualIncome * 0.16;
        }
    }
}
