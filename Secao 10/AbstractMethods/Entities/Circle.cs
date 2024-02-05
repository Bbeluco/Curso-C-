namespace AbstractMethods;

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double area()
    {
        return 3.1415 * (Radius*Radius);
    }

    public Circle(Color color, double radius) 
        : base(color)
    {
        Radius = radius;
    }
}
