using System;
using Exercicio2;

namespace EnumerationAndComposition {
    internal class Exercicio2 {
        static void Main(string[] args) {
            string title = "Traveling to New Zeland";
            int likes = 12;
            string content = "I'm going to visit this amazing country!";

            Post p1 = new Post(title, content, likes);

            p1.Comments.Add(new Comment{ Text = "Have a nice trip!"});
            p1.Comments.Add(new Comment{ Text = "Wow thats awesome"});

            System.Console.WriteLine(p1);
        }
    }
}