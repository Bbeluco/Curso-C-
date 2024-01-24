using System;

namespace ObjectOrientationPillars {
    internal class CadastroProduto {
        static void Main(string[] args) {
            System.Console.WriteLine("Entre com os dados do produto:");
            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("Preco: ");
            double preco = double.Parse(Console.ReadLine());
            System.Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            System.Console.WriteLine("Dados do produto: " + p);

            System.Console.Write("Digite um numero de produtos a ser adicionado ao estoque: ");
            p.AdicionarProdutos(int.Parse(Console.ReadLine()));

            System.Console.WriteLine("Dados atualizados: " + p);

            System.Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            p.RemoverProdutos(int.Parse(Console.ReadLine()));

            System.Console.WriteLine("Dados atualizados: " + p);
        }
    }
}