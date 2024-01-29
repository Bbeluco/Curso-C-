using System;
/*
    Lists = LinkedLists implemented in C#. For more details of how this data struct works
    consult the book "grooking algorithms"
*/

namespace StructsDataStructure {
    internal class LinkedLists {
        static void Main(string[] args) {


            List<string> nomes = new List<string> { "Bruno", "Giovana", "Fiona", "Marco"};
            nomes.Add("Ultimo colocado");
            nomes.Insert(2, "Novo elemento 2 pos");

            foreach(string nome in nomes) {
                System.Console.WriteLine(nome);
            }
            System.Console.WriteLine();
            string pessoa = nomes.Find(n => n.Length == 5);
            System.Console.WriteLine("Nome com 5 letras: " + pessoa);
        }
    }
}