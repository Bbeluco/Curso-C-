using System;
using System.Globalization;
using Exercicio1;

namespace EnumerationAndComposition {
    internal class Exercicio1  {
        static void Main(string[] args){
            System.Console.Write("Enter department's name: ");
            string departmentName = Console.ReadLine();

            System.Console.WriteLine("Enter worker data: ");
            System.Console.Write("Name: ");
            string workerName = Console.ReadLine();
            System.Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            System.Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Worker worker = new Worker { 
                Name = workerName,
                Level = workerLevel,
                BaseSalary = baseSalary,
                Department = new Department() { Name = departmentName }
            };

            System.Console.Write("How many contracts to this worker? ");
            int quantityContracts = int.Parse(Console.ReadLine());

            System.Console.WriteLine();
            for(int i = 0; i < quantityContracts; ++i) {
                System.Console.WriteLine($"Enter #{i+1} contract data: ");
                System.Console.Write("Date: ");
                DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                System.Console.Write("Value per hour: ");
                double contractValuePerHour = double.Parse(Console.ReadLine());
                System.Console.Write("Duration: ");
                int durationContract = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract { 
                    Date = contractDate,
                    ValuePerHour = contractValuePerHour,
                    Hours = durationContract
                };
                worker.AddContract(contract);
            }

            System.Console.WriteLine();

            System.Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "MM/yyyy", CultureInfo.InvariantCulture);
            System.Console.WriteLine("Name: " + worker.Name);
            System.Console.WriteLine("Department: " + worker.Department.Name);
            System.Console.WriteLine($"Income for {date}: {worker.Income(date.Month, date.Year)}");
        }
    }
}