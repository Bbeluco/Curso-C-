namespace AbstractMethods;

public abstract class Shape
{
    public Color Color { get; set; }

    public abstract double area();

    public Shape() {}

    public Shape(Color color) {
        Color = color;
    }
}
