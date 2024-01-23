using System;
using Exercicio6;

namespace IntroductionClasses {
    internal class Exercicio6 {
        static void Main(string[] args){
            System.Console.Write("Qual a cotacao do dolar? ");
            double cotacao = double.Parse(Console.ReadLine());

            System.Console.Write("Quantos dolares voce vai comprar? ");
            double compra = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Valor total a ser pago: " + CalculaDolar.CalculaPrecoPago(compra, cotacao).ToString("F2"));
        }
    }
}