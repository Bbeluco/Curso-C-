using System;
using Exercicio1;

namespace ObjectOrientationPillars {
    internal class Exercicio1 {
        static void PrintConta(ContaBancaria cb) {
            System.Console.WriteLine();
            System.Console.WriteLine("Dados da conta: ");
            System.Console.WriteLine(cb);
            System.Console.WriteLine();
        }

        static void Main(string[] args) {
            ContaBancaria cb;

            System.Console.Write("Entre com o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());

            System.Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            System.Console.Write("Havera deposito inicial (s/n)? ");
            char depInicial = char.Parse(Console.ReadLine());

            if(depInicial == 'n') {
                cb = new ContaBancaria(conta, titular);
            } else {
                System.Console.Write("Entre o valor do deposito inicial: ");
                double deposito = double.Parse(Console.ReadLine());
                cb = new ContaBancaria(conta, titular, deposito);
            }

            PrintConta(cb);

            System.Console.Write("Entre com um valor de deposito: ");
            cb.Deposito(double.Parse(Console.ReadLine()));

            PrintConta(cb);

            System.Console.Write("Entre com um valor de saque: ");
            cb.Saque(double.Parse(Console.ReadLine()));

            PrintConta(cb);
        }
    }
}