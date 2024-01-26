using System;
using Params;

namespace StructsDataStructure {
    internal class Params {
        static void Main(string[] args) {
            int n1 = Calculator.Soma(1,2,3);
            int n2 = Calculator.Soma(1,2);
            int n3 = Calculator.Soma(1);
            
            System.Console.WriteLine(n1);
            System.Console.WriteLine(n2);
            System.Console.WriteLine(n3);
        }
    }
}