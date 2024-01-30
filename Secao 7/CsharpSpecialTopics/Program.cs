using System;

/*
    Var works exactly the same as "auto" in C++
*/

namespace CsharpSpecialTopics {
    internal class TypeInference {
        static void Main(string[] args) {
            var a = "Bruno";
            var b = 10.0;
            var c = 10;

            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(c);
        }
    }
}