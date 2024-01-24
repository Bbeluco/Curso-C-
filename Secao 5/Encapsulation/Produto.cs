namespace Encapsulation;

public class Produto {
    private string _nome;
    private double _preco;
    private int _quantidade;

    public Produto(string nome, double preco, int quantidade) {
        _nome = nome;
        _preco = preco;
        _quantidade = quantidade;
    }

    public string GetNome() {
        return _nome;
    }

    public double GetPreco() {
        return _preco;
    }

    public int GetQuantidade() {
        return _quantidade;
    }

    public void SetQuantidade(int qtd) {
        _quantidade = qtd;
    }
}
