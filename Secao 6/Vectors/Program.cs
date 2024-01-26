using System;

namespace Vectors {
    internal class Program {
        static void Main(string[] args) {
            System.Console.Write("Quantos dados deseja inserir? ");
            int n = int.Parse(Console.ReadLine());

            double[] alturas = new double[n];

            for(int i = 0; i < n; ++i) {
                System.Console.Write($"Digite a {i+1} altura: ");
                alturas[i] = double.Parse(Console.ReadLine());
            }

            double avg = 0;

            for(int i = 0; i < n; ++i) {
                avg += alturas[i];
            }

            System.Console.WriteLine("Altura media: " + (avg/n).ToString("F2"));
        }
    }
}