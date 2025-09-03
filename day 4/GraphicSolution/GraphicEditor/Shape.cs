namespace Drawing;

 public enum Color
    {
        Red,
        Green,
        Blue,
        Yellow,
        Black,
        White
    }
public abstract class Shape
{

    public int Thickness { get; set; }

    public Color ShapeColor { get; set; }
    public abstract void Draw();
}