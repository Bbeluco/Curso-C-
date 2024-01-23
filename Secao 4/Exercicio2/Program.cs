using System;
using Exercicio2;

namespace IntroductionClasses {
    internal class Program {
        static Funcionario CadastraFuncionario() {
            Funcionario f = new Funcionario();
            System.Console.Write("nome: ");
            f.Nome = Console.ReadLine();

            System.Console.Write("salario: ");
            f.Salario = double.Parse(Console.ReadLine());

            return f;
        }

        static double CalculaMediaSalarial(Funcionario a, Funcionario b) {
            return (a.Salario + b.Salario) / 2;
        }

        static void Main(string[] args) {
            Funcionario a,b;
            b = new Funcionario();

            System.Console.WriteLine("Dados do primeiro funcinario: ");
            a = CadastraFuncionario();

            System.Console.WriteLine("Dados do segundo funcionario: ");
            b = CadastraFuncionario();

            System.Console.WriteLine("Media salarial: " + CalculaMediaSalarial(a, b));
        }
    }
}