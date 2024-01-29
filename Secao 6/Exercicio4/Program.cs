using System;

namespace StructsDataStructure {
    internal class Exercicio4 {
        static void Main(string[] args) {
            System.Console.Write("How big will be your matrix: ");
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];

            int[] mainDiagonal = new int[size];
            int countNegative = 0;

            for(int i = 0; i < size; ++i) {
                string[] numbers = Console.ReadLine().Split(' ');
                for(int j = 0; j < size; ++j) {
                    int n1 = int.Parse(numbers[j]);
                    matrix[i, j] = n1;
                    if(matrix[i,j] < 0) {
                        ++countNegative;
                    }

                    if(i == j) {
                        mainDiagonal[i] = n1;
                    }
                }
            }

            System.Console.WriteLine("Main diagonal: ");
            foreach(int n in mainDiagonal) {
                System.Console.Write($"{n} ");
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Negative numbers: " + countNegative);
        }
    }
}