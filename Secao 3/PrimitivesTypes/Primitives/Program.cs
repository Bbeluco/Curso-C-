namespace PrimitivesTypes {
    internal class Primitives {
        static void Main(string[] args) {
            SByte x = 100;
            int y = 10000;
            float z = 5.4f;
            double b = 6.6;
            long a = 12L;
            char c = 'a';
            char euro = '\u00A3';
            string name = "Bruno"; //This isnt a primitive type but it is a very common type


            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
            System.Console.WriteLine(z);
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(c);
            System.Console.WriteLine(euro);
            System.Console.WriteLine(name);
        }
    }
}
