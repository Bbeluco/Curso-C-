using System;

namespace WhileLoop {
    internal class WhileLoop {
        static void Main(string[] args) {
            int x = 0;

            while(x >= 0) {
                System.Console.Write("Escolha um numero (negativo para sair): ");
                x = int.Parse(Console.ReadLine());
                if(x >= 0) {
                    System.Console.WriteLine("A Raiz quadrada desse numero eh: " + Math.Sqrt(x));
                }
            }
        }
    }
}