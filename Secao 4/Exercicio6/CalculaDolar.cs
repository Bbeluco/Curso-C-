namespace Exercicio6;

public class CalculaDolar {
    public static double IoF = 6;

    public static double CalculaPrecoPago(double quantidade, double cotacao) {
        double preco = quantidade*cotacao;
        
        return preco + (preco*(IoF/100));
    }
}
