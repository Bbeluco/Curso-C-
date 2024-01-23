using System;
using System.Diagnostics;
using Exercicio1;

namespace IntroductionClasses{
    internal class Program {
        static Pessoa MaiorIdade(Pessoa a, Pessoa b) {
            if(a.Idade > b.Idade) {
                return a;
            } else {
                return b;
            }
        }

        static void Main(string[] args){
            Pessoa a, b;
            a = new Pessoa();
            b = new Pessoa();

            System.Console.WriteLine("Dados da primeira pessoa:");
            System.Console.Write("nome: ");
            a.Nome = Console.ReadLine();

            System.Console.Write("idade: ");
            a.Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Dados da segunda pessoa:");
            System.Console.Write("nome: ");
            b.Nome = Console.ReadLine();
            
            System.Console.Write("idade: ");
            b.Idade = int.Parse(Console.ReadLine());

            System.Console.WriteLine("A pessoa de maior idade eh: " + MaiorIdade(a,b).Nome);
        }
    }
}