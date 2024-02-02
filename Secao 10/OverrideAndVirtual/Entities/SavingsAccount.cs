namespace OverrideAndVirtual;

public class SavingsAccount : Account
{
    public double InterestRate { get; set; }

    public SavingsAccount(int number, string holder, double balance, double interestRate) 
    : base(number, holder, balance)
    {
        InterestRate = interestRate;
    }

    public void UpdateBalance() {
        Balance += Balance * InterestRate;
    }


    //In this context "sealed" means the method cannot be override
    public sealed override void WithDraw(double amount)
    {

        //"base" means we're using the father class
        base.WithDraw(amount);
        Balance -= 2;
    }
}
