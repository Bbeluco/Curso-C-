namespace ThisWord;

public class Pessoa {
    public string Nome;
    public int Idade;
    public char Sexo;

    public Pessoa() {
        Nome = "NAO DEFINIDO";
        Idade = -1;
        Sexo = '?';
    }

    public Pessoa(string nome, int idade) : this() {
        Nome = nome;
        Idade = idade;
    }

    public Pessoa(String nome, int idade, char sexo) : this(nome, idade) {
        Sexo = sexo;
    }

    public override string ToString(){
        return $"{Nome}, {Idade} e {Sexo}";
    }
}
