using System;
using CadastroProduto;

namespace IntroductionClasses {
    internal class CadastroProduto {
        static void Main(string[] args) {
            Produto p = new Produto();
            System.Console.WriteLine("Entre com os dados do produto:");
            System.Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            System.Console.Write("Preco: ");
            p.Preco = double.Parse(Console.ReadLine());

            System.Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

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