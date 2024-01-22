using System;

namespace Functions {
    internal class Functions {
        static int Maior(int a, int b, int c) {
            if(a > b && a > c) {
                return a;
            } else if (b > c) {
                return b;
            } else {
                return c;
            }
        }

        static void Main(string[] args) {
            System.Console.Write("Digite o primeiro numero: ");
            int n1 = int.Parse(Console.ReadLine());

            System.Console.Write("Digite o segundo numero: ");
            int n2 = int.Parse(Console.ReadLine());

            System.Console.Write("Digite o terceiro numero: ");
            int n3= int.Parse(Console.ReadLine());

            System.Console.WriteLine("O maior numero eh: " + Maior(n1, n2, n3));
        }
    }
}