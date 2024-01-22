using System;

namespace Conditionals {
    internal class Conditionals {
        static void Main(string[] args) {
            int time = 3;

            if(time > 6 && time < 12) {
                System.Console.WriteLine("Good morning!");
            } else if(time >= 12 && time < 18) {
                System.Console.WriteLine("Good afternoon!");
            } else {
                System.Console.WriteLine("Good night");
            }
        }
    }
}