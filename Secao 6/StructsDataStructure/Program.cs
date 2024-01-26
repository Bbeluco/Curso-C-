using System;

namespace StructsDataStructure {
    internal class Program {
        static void Main(string[] args) {
            //The main idea about structs is exactly the same as in C++
            //If you have any doubts please see learncpp.com

            Point p = new Point();
            System.Console.WriteLine(p);

            p.X = 1;
            p.Y = 2;

            System.Console.WriteLine(p);
        }
    }
}