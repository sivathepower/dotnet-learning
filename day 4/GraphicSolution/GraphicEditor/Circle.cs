using Drawing;

public class Circle : Shape, IDisposable
{
    public int Radius { get; set; }
    public Point Center { get; set; }

    public Circle(int radius, Point center, Color color, int thickness)
    {
        Radius = radius;
        Center = center;
        ShapeColor = color;
        Thickness = thickness;
    }
    public override void Draw()
    {
        Console.WriteLine("Drawing a {ShapeColor} Circle at " + Center + " with radius " + Radius);
    }

    // Out keyword used to return multiple values from a method 
    // because a method can return only one value at a time.
    public void Calculate(out double area, out double circumference)
    {
        area = Math.PI * Radius * Radius;
        circumference = 2 * Math.PI * Radius;
    }
    ~Circle()
    {
    }
    public void Dispose()
    {
        Console.WriteLine("Disposing Circle");
        GC.SuppressFinalize(this);
    }

}