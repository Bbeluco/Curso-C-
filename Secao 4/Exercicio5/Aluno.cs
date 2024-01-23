using System.Diagnostics.Contracts;

namespace Exercicio5;

public class Aluno {
    public string Nome;
    public double N1, N2, N3;

    public double NotaFinal() {
        return N1 + N2 + N3;
    }

    public bool Aprovado() {
        if(NotaFinal() > 60) {
            return true;
        }
        return false;
    }

    public double NotaRestante() {
        return 60 - NotaFinal();
    }
}
