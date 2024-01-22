using System;

namespace ParseInput {
    internal class Input {
        static void Main(string[] args) {
            System.Console.Write("Digite seu nome completo: ");
            string nome = Console.ReadLine();

            System.Console.Write("Quantos quartos tem na sua casa: ");
            int quartos = int.Parse(Console.ReadLine());

            System.Console.Write("Entre com o preco de um produto: ");
            double preco = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre seu ultimo nome, idade e altura (na mesma linha): ");
            string[] atributos = Console.ReadLine().Split(' ');

            System.Console.WriteLine(nome);
            System.Console.WriteLine(quartos);
            System.Console.WriteLine(preco);
            System.Console.WriteLine(atributos[0]);
            System.Console.WriteLine(atributos[1]);
            System.Console.WriteLine(atributos[2]);
        }
    }
};
