using System;

namespace Exceptions {
    internal class Program {
        static void Main(string[] args) {
            try {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
            }
            catch (DivideByZeroException) 
            {
                System.Console.WriteLine("Divide by 0 is not allowed");
            }
            catch(FormatException e)
            {
                System.Console.WriteLine("(Letters are not allowed) " + e.Message);
            }
        }
    }
}