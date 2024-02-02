using System;
using System.Data;
using Exercicio1;

namespace InheritanceAndPolimorphism {
    internal class Exercicio1 {
        static void Main(string[] args){
            System.Console.Write("Enter the number of employees: ");
            int nEmployees = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for(int i = 1; i <= nEmployees; ++i) {
                System.Console.WriteLine($"Employee #{i} data: ");
                System.Console.Write("Outsourced (y/n)? ");
                char outsourced = char.Parse(Console.ReadLine().ToLower());

                System.Console.Write("Name: ");
                string name = Console.ReadLine();
                System.Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                System.Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if(outsourced == 'y') {
                    System.Console.Write("Aditional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    OutsourcedEmployee outsourcedEmployee = new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge);
                    employees.Add(outsourcedEmployee);
                } else {
                    Employee employee = new Employee(name, hours, valuePerHour);
                    employees.Add(employee);
                }
            }

            foreach(Employee e in employees) {
                System.Console.WriteLine($"{e.Name} - $ {e.Payment()}");
            }
        }
    }
}