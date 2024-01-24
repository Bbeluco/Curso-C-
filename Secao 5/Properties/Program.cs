using System;
using Properties;

namespace ObjectOrientationPillars {
    internal class Properties {
        static void Main(string[] args) {
            Produto p = new Produto("TV", 900.0, 10);
            System.Console.WriteLine(p);
            p.Nome = "Abacaxi";

            System.Console.WriteLine(p);

            p.Nome = "B";
            System.Console.WriteLine(p);
        }
    }
}