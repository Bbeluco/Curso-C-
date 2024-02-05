using System;
using Exercicio3;

namespace InheritanceAndPolimorphism {
    internal class Exercicio3 {
        static void Main() {
            System.Console.Write("Enter the number of tax payers: ");
            int qtdPayers = int.Parse(Console.ReadLine());
            List<TaxPayers> taxPayers = new List<TaxPayers>();
            for(int i = 1; i <= qtdPayers; ++i) {
                System.Console.WriteLine();
                System.Console.WriteLine($"Tax payer #{i} data: ");
                System.Console.Write("Individual or Company (c/i)? ");
                char type = char.Parse(Console.ReadLine().ToLower());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());
                if(type == 'i') {
                    System.Console.Write("Health expenditures: ");
                    double healthExp = double.Parse(Console.ReadLine());
                    taxPayers.Add(new Individual(name, anualIncome, healthExp));
                } else {
                    System.Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, anualIncome, employees));
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("TAXES PAID: ");
            double totalTaxes = 0;
            foreach(TaxPayers payer in taxPayers) {
                System.Console.WriteLine($"{payer.Name}: ${payer.TaxesPaid():F2}");
                totalTaxes += payer.TaxesPaid();
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Total Taxes: $" + totalTaxes.ToString("F2"));
        }
    }
}