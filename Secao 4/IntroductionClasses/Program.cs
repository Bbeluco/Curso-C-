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

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p-x.A) * (p-x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p-y.A) * (p-y.B) * (p - y.C));

            System.Console.WriteLine("Area de X: " + areaX);
            System.Console.WriteLine("Area de Y: " + areaY);

            if(areaX > areaY) {
                System.Console.WriteLine("Maior area: X");
            } else {
                System.Console.WriteLine("Maior area: Y");
            }
        }
    }
}
