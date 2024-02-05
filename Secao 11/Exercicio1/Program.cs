using System;
using Exercicio1;

namespace Exceptions {
    internal class Exercicio1 {
        static void Main(string[] args) {
            try {
                System.Console.WriteLine("Enter account data: ");
                System.Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                System.Console.Write("Holder: ");
                string holder = Console.ReadLine();
                System.Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                System.Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, balance, withdrawLimit);

                System.Console.WriteLine();
                System.Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());
                account.Withdraw(amount);
                System.Console.WriteLine("New balance: " + account.Balance.ToString("F2"));
            }
            catch(DomainException e) {
                System.Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}