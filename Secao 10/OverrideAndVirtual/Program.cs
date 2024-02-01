using System;
using OverrideAndVirtual;

namespace InheritanceAndPolimorphism {
    internal class OverrideAndVirtual {
        static void Main() {
            Account acc1 = new BusinessAccount(123, "Bruno", 500.00, 5000.00);
            Account acc2 = new SavingsAccount(456, "Giovana", 500.00, 0.01);

            acc1.WithDraw(10);
            acc2.WithDraw(10);

            System.Console.WriteLine(acc1.Balance);
            System.Console.WriteLine(acc2.Balance);
        }
    }
}