using System;

namespace ForLoop {
    internal class ForLoop {
        static void Main(string[] args) {
            System.Console.Write("Quantos valores deseja inserir? ");
            int qtd = int.Parse(Console.ReadLine());
            int soma = 0;
            for(int i = 1; i <= qtd; ++i) {
                System.Console.Write($"Valor #{i}: ");
                int valor = int.Parse(Console.ReadLine());

                soma += valor;
            }

            System.Console.WriteLine("Soma: " + soma);
        }
    }
}