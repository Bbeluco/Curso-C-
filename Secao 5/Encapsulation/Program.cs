using System;
using Encapsulation;

namespace ObjectOrientationPillars {
    internal class Encapsulation {
        static void Main(string[] args){
            Produto p = new Produto("TV", 500.0, 10);
            p.SetQuantidade(14);
            System.Console.WriteLine(p.GetQuantidade());

        }
    }
}