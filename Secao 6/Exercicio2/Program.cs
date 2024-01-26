using System;
using Exercicio2;

namespace StructsDataStructure {
    internal class Exercicio2 {
        static void Main(string[] args) {
            System.Console.Write("How many rooms will be rented? ");
            int rooms = int.Parse(Console.ReadLine());

            Rooms[] availableRooms = new Rooms[10];

            for(int i = 0; i < rooms; ++i) {
                Students students = new Students();

                System.Console.WriteLine();
                System.Console.WriteLine($"Rent #${i+1}:");
                System.Console.Write("Name: ");
                students.Name = Console.ReadLine();
                System.Console.Write("Email: ");
                students.Email = Console.ReadLine();
                System.Console.Write("Room: ");
                students.Room = int.Parse(Console.ReadLine());

                availableRooms[students.Room] = new Rooms(students);
            }

            System.Console.WriteLine("Busy rooms:");
            for(int i = 0; i < 10; ++i) {
                if (availableRooms[i] != null) {
                    System.Console.WriteLine(availableRooms[i].Students);
                }
            }
        }
    }
}
