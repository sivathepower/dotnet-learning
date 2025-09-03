namespace Drawing;

//class relationship  1)is a relationship ---inheritancde 2) has a relationship --composition
public class Line : Shape, IDisposable
{
    public Point Start { get; set; }
    public Point End { get; set; }
    public Line(Point start, Point end)
    {
        Start = start;
        End = end;
    }
    public Line(Point start, Point end, Color color, int thickness)
    {
        Start = start;
        End = end;
        ShapeColor = color;
        Thickness = thickness;
    }
    public override void Draw()
    {
        Console.WriteLine($"Drawing a {ShapeColor} line from {Start} to {End} with thickness {Thickness}");
    }
    ~Line()
    {
        Console.WriteLine("Line object is being destroyed");
    }
    public void Dispose()
    {
        // Clean up any resources here
        // Console.WriteLine("Disposing Line object");
        GC.SuppressFinalize(this);
    }
}                                               