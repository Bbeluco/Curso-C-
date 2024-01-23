using System;
using Exercicio4;

namespace IntroductionClasses {
    internal class Exercicio4 {
        static void Main(string[] args) {
            Funcionario f = new Funcionario();
            System.Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            System.Console.Write("Salario Bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine());

            System.Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Funcionario: " + f);

            System.Console.Write("Digite a porcentagem para aumentar o salário: ");
            f.AumentarSalario(double.Parse(Console.ReadLine()));

            System.Console.WriteLine("Dados atualizados: " + f);
        }
    }
}