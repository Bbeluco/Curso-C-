using System;

namespace InputData {
    internal class Input {
        static void Main(string[] args) {
            System.Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            System.Console.Write("Digite uma cor: ");
            string cor1 = Console.ReadLine();
            System.Console.Write("Digite uma cor: ");
            string cor2 = Console.ReadLine();
            System.Console.Write("Digite uma cor: ");
            string cor3 = Console.ReadLine();

            System.Console.Write("Digite varias cores na mesma linha: ");
            string multicores = Console.ReadLine();

            string[] cores = multicores.Split(' ');


            System.Console.WriteLine("Voce digitou a frase: " + frase);
            System.Console.WriteLine("Cor1: " + cor1);
            System.Console.WriteLine("Cor2: " + cor2);
            System.Console.WriteLine("Cor3: " + cor3);

            System.Console.WriteLine("Multi cor1: " + cores[0]);
            System.Console.WriteLine("Multi cor1: " + cores[1]);
            System.Console.WriteLine("Multi cor1: " + cores[2]);
        }
    }
}