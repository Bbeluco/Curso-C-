namespace Exercicio1;

public class ContaBancaria {
    private int _conta;
    public string Titular { get; set;}
    private double Saldo { get; set;}

    public ContaBancaria(int conta, string titular) {
        _conta = conta;
        Titular = titular;
    }

    public ContaBancaria(int conta, string titular, double depositoInicial) : this(conta, titular) {
        Deposito(depositoInicial);
    }

    public void Deposito(double quantidade) {
        Saldo += quantidade;
    }

    public void Saque(double quantidade) {
        double taxa = 5.0;
        Saldo -= quantidade + taxa;
    }

    public override string ToString() {
        return $"Conta {_conta}, Titular: {Titular}, Saldo: {Saldo:F2}";
    }
}
