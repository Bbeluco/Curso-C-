using System;

namespace StructsDataStructure {
    internal class ForEachStructure{
        static void Main(string[] args) {
            string[] nomes = new string[] { "Bruno", "Giovana", "Fiona" };

            foreach(string nome in nomes ) {
                System.Console.WriteLine(nome);
            }
        }
    }
}