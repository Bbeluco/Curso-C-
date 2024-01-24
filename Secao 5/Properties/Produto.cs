namespace Properties;

public class Produto {
    private string _nome;
    public double Preco { get; } //Auto property
    public int Quantidade { get; } //Auto property

    public Produto(string nome, double preco, int quantidade) {
        _nome = nome;
        Preco = preco;
        Quantidade = quantidade;
    }

    //value = o parametro que receberiamos em um set normal
    //setNome(AQUI_SERIA_O_VALUE)
    public string Nome {
        get { return _nome; }
        set { 
            if(value != null && value.Length > 1) {
                _nome = value;
            }
        }
    }

    public override string ToString() {
        return $"{_nome}, {Preco}, {Quantidade}";
    }
}
