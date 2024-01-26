using System;
using ReferencesAndOut;

namespace StructsDataStructure {
    internal class ReferencesAndOut {
        static void Main(string[] args){
            int x = 1;
            int y;

            Calculator.Triple(ref x);
            Calculator.Double(2, out y);

            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
        }
    }
}