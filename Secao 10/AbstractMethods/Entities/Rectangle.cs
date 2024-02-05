namespace AbstractMethods;

public class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double area()
    {
        return Width * Height;
    }

    public Rectangle(Color color, double width, double height) 
        : base(color)
    {
        Width = width;
        Height = height;
    }
}
