using System;
using Exercicio1;

namespace StructsDataStructure {
    internal class Exercicio1 {
        static void Main(string[] args) {
            System.Console.Write("Quantos produtos deseja inserir? ");
            int qtd = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[qtd];

            for(int i = 0; i < qtd; ++i) {
                produtos[i] = new Produto();

                System.Console.Write($"Digite o nome do {i+1} produto: ");
                produtos[i].Nome = Console.ReadLine();
                System.Console.Write($"Digite o preco de {produtos[i].Nome}: ");
                produtos[i].Preco = double.Parse(Console.ReadLine());
                System.Console.WriteLine();
            }

            double somaProdutos = 0;

            for(int i = 0; i < qtd; ++i) {
                somaProdutos += produtos[i].Preco;
            }

            System.Console.WriteLine("O preco medio eh: " + (somaProdutos/qtd).ToString("F2"));
        }
    }
}