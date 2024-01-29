using System;

namespace StructsDataStructure {
    internal class Exercicio5 {
        static void Main(string[] args) {
            string[] dimensions = Console.ReadLine().Split(' ');
            int lines = int.Parse(dimensions[0]);
            int columns = int.Parse(dimensions[1]);
            int[,] mat = new int[lines, columns];

            for(int i = 0; i < lines; ++i) {
                string[] numbers = Console.ReadLine().Split(' ');
                for(int j = 0; j < columns; ++j) {
                    mat[i, j] = int.Parse(numbers[j]);
                }
            }

            System.Console.Write("Enter a number to search: ");
            int number = int.Parse(Console.ReadLine());

            for(int i = 0; i < lines; ++i) {
                for(int j = 0; j < columns; ++j) {
                    if(mat[i, j] == number) {
                        System.Console.WriteLine($"Position {i},{j}: ");
                        if(j > 0) {
                            System.Console.WriteLine("Left: " + mat[i, j-1]);
                        }

                        if(j < columns - 1) {
                            System.Console.WriteLine("Right: " + mat[i, j+1]);
                        }

                        if(i < lines - 1) {
                            System.Console.WriteLine("Down: " + mat[i+1 ,j]);
                        }

                        if(i > 0) {
                            System.Console.WriteLine("Up: " + mat[i-1 ,j]);
                        }

                        System.Console.WriteLine();
                    }
                }
            }
        }
    }
}