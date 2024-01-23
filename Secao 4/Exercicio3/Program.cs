using System;
using Exercicio3;

namespace IntroductionClasses {
    internal class Exercicio3 {
        static void Main(string[] args) {
            Retangulo r = new Retangulo();
            
            System.Console.WriteLine("Entre a largura e altura do retangulo: ");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Area: " + r.Area().ToString("F2"));
            System.Console.WriteLine("Perimetro: " + r.Perimetro().ToString("F2"));
            System.Console.WriteLine("Diagonal: " + r.Diagonal().ToString("F2"));
        }
    }
}