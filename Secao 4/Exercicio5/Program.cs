using System;
using Exercicio5;

namespace IntroductionClasses {
    internal class Exercicio5 {
        static void Main(string[] args) {
            Aluno a = new Aluno();

            System.Console.Write("Nome do aluno: ");
            a.Nome = Console.ReadLine();
            System.Console.WriteLine("Digite as três notas do aluno:");
            a.N1 = double.Parse(Console.ReadLine());
            a.N2 = double.Parse(Console.ReadLine());
            a.N3 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Nota final: " + a.NotaFinal().ToString("F2"));
            if(a.NotaFinal() >= 60) {
                System.Console.WriteLine("APROVADO");
            } else {
                System.Console.WriteLine("REPROVADO");
                System.Console.WriteLine($"FALTARAM {a.NotaRestante().ToString("F2")} PONTOS");
            }
        }
    }
}