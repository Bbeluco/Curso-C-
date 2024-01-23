using System;

namespace IntroductionClasses {
    internal class Program {
        static void Main(string[] args) {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            System.Console.WriteLine("Entre com as medidas do triangulo X: ");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com as medidas do triangulo Y: ");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            double areaY = y.Area();

            System.Console.WriteLine("Area de X: " + areaX.ToString("F2"));
            System.Console.WriteLine("Area de Y: " + areaY.ToString("F2"));

            if(areaX > areaY) {
                System.Console.WriteLine("Maior area: X");
            } else {
                System.Console.WriteLine("Maior area: Y");
            }
        }
    }
}
