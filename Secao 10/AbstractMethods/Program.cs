using System;
using System.Data;
using AbstractMethods;

namespace InheritanceAndPolimorphism {
    internal class AbstractMethods {
        static void Main(string[] args) {
            System.Console.Write("Enter the number os shapes: ");
            int shapes = int.Parse(Console.ReadLine());

            List<Shape> shapes1 = new List<Shape>();
            for(int i = 1; i <= shapes; ++i) {
                System.Console.WriteLine($"Shape #{i} data: ");
                System.Console.Write("Rectangle or Circle: ");
                char form = char.Parse(Console.ReadLine().ToLower());
                System.Console.Write("Color (Black, Blue, Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine().ToUpper());
                if(form == 'r') {
                    System.Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    System.Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());

                    shapes1.Add(new Rectangle(color, width, height));
                } else {
                    System.Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes1.Add(new Circle(color, radius));
                }
            }

            System.Console.WriteLine("SHAPE AREAS: ");
            foreach(Shape shape in shapes1) {
                System.Console.WriteLine(shape.area().ToString("F2"));
            }
        }
    }
}