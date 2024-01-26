using System;


namespace StructsDataStructure {
    internal class Nullable {
        static void Main(string[] args) {
            //The 2 lines below has the same goal (make some struct type nullable)
            //Nullable = means your type can be null
            //Nullables are a good way when we have optional values that need to be set (like in REST response)
            double? x = null;
            Nullable<double> y = null;

            //The 3 common methods in nullable are
            System.Console.WriteLine(x.GetValueOrDefault());
            System.Console.WriteLine(x.HasValue);
            // System.Console.WriteLine(y.Value); //Throws exception when theres no value

            // Null-conditional-operator
            // It is the same as any other circuit-break in JS (like: a = x || 10)

            double a = x ?? 3;

            System.Console.WriteLine(a);
        }
    }
}