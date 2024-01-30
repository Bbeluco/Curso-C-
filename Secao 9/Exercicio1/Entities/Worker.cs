namespace Exercicio1;

public class Worker
{
    public string Name { get; set; }
    public WorkerLevel Level { get; set; }
    public double BaseSalary { get; set; }

    //Composition
    private List<HourContract> _contracts { get; set; } = new List<HourContract>();
    public Department Department { get; set; }

    public void AddContract(HourContract contract) {
        _contracts.Add(contract);
    }

    public void RemoveContract(HourContract contract) {
        _contracts.Remove(contract);
    }

    public double Income(int year, int month) {
        double contractPayment = BaseSalary;
        
        foreach(HourContract h in _contracts) {
            if(h.Date.Month + '/' + h.Date.Year == month+ '/' +year)
            contractPayment += h.TotalValue();
        }
        
        return contractPayment;
    }
}
