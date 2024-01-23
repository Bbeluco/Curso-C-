﻿namespace CadastroProduto;

public class Produto {
    public string Nome;
    public double Preco;
    public int Quantidade;

    public double ValorTotalEmEstoque() {
        return Quantidade * Preco;
    }

    public void AdicionarProdutos(int quantity) {
        Quantidade += quantity;
    }

    public void RemoverProdutos(int quantity) {
        Quantidade -= quantity;
    }

    public override string ToString() {
        return $"Dados do produto: {Nome}, ${Preco:F2}, {Quantidade} unidades. Total: " + ValorTotalEmEstoque();
    }
}
