using System;
using ThisWord;

namespace ObjectOrientationPillars {
    internal class ThisWord {
        static void Main(string[] args) {
            System.Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            System.Console.Write("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            System.Console.Write("Digite seu sexo: ");
            char sexo = char.Parse(Console.ReadLine());

            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa(nome, idade);
            Pessoa p3 = new Pessoa(nome, idade, sexo);

            System.Console.WriteLine(p1);
            System.Console.WriteLine(p2);
            System.Console.WriteLine(p3);
        }
    }
}