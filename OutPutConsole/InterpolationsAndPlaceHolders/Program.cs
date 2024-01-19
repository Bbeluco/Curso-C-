using System;
using System.Globalization;

namespace OutPutConsole {
    internal class InterpolationsAndPlaceHolders {
        static void Main(string[] args) {
            string name = "Bruno";
            double balance = 23.34582;
            int age = 21;

            System.Console.WriteLine($"{name} has ${balance:F2} and is ${age} years old");
            System.Console.WriteLine("{0} has ${1:F2} and is {2} years old", name, balance, age);
            System.Console.WriteLine();

            string product1 = "Computer";
            string product2 = "Office desk";

            byte age1 = 30;
            int code = 5290;
            char gender = 'M';

            double price1 = 2100.0;
            double price2 = 650.50;
            double measure = 53.234567;

            System.Console.WriteLine("Products:");
            System.Console.WriteLine($"{product1} whose price is $ {price1}");
            System.Console.WriteLine($"{product2} whose price is$ {price2}");
            System.Console.WriteLine();

            System.Console.WriteLine($"Register: {age1} years old, code {code} and gender {gender}");
            System.Console.WriteLine();

            System.Console.WriteLine($"Measure with eight decimal places: {measure}");
            System.Console.WriteLine($"Rounded (three decimal places): {measure:F3}");
            System.Console.WriteLine("Separator decimal invariant culture: " +  measure.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}