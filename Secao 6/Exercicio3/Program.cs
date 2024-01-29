using System;
using System.Data.Common;
using Exercicio3;

namespace StructsDataStructure {
    internal class Exercicio3 {
        static void Main(string[] args) {
            List<Employee> employees = new List<Employee>();
            
            
            System.Console.Write("How many employees will be registered? ");
            int quantity = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantity; ++i) {
                System.Console.WriteLine($"Employee #{i+1}:");
                System.Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                System.Console.WriteLine();

                employees.Add(new Employee(id, name, salary));
            }

            System.Console.Write("Enter the employee id that will have salary increase: ");
            int employeeId = int.Parse(Console.ReadLine());
            Employee? employee = employees.Find(e => e.Id == employeeId);
            if(employee != null) {
                System.Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());
                employee.IncreaseSalary(percentage);
            } else {
                System.Console.WriteLine("The employee do not exist!");
            }

            System.Console.WriteLine();

            foreach(Employee e in employees) {
                System.Console.WriteLine(e);
            }
        }
    }
}