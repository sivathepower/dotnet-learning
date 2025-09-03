using Drawing;
using System.Collections.Generic;

// using ()keyword with {} ,automatically handles the disposal of objects that implement IDisposable interface
// The using statement ensures that the Dispose method is called on the object when it goes out of scope, even if an exception occurs within the using block.
using (List<Line> lines = new List<Line>())
{   Line l1 = new Line(new Point(1, 2), new Point(3, 4));
    Line l2 = new Line(new Point(5, 6), new Point(7, 8), Color.Red, 5);
    Line l3 = new Line(new Point(59, 69), new Point(79, 89), Color.Red, 5);

    lines.Add(l1);
    lines.Add(l2);
    lines.Add(l3);
}


// List<Line> lines = new List<Line>();
//     Line l1 = new Line(new Point(1, 2), new Point(3, 4));
//     Line l2 = new Line(new Point(5, 6), new Point(7, 8), Color.Red, 5);
//     Line l3 = new Line(new Point(59, 69), new Point(79, 89), Color.Red, 5);
//     lines.Add(l1);
//     lines.Add(l2);
//     lines.Add(l3);
//      foreach (var line in lines)
//     {
//         line.dispose();
//     }


Console.WriteLine("End of Main method");

//disposing technique
// for (int i = 0; i < 10; i++)
// {
//     Line l1 = new Line(new Point(1, 2), new Point(3, 4));
//     Line l2 = new Line(new Point(5, 6), new Point(7, 8), Color.Red, 5);
//     Line l3 = new Line(new Point(59, 69), new Point(79, 89), Color.Red, 5);
//     l1.dispose();
//     l2.dispose();
//     l3.dispose();

// }


// circle concept
Circle c1 = new Circle(5, new Point(10, 20), Color.Blue, 3);
//c1.Draw();
//need to pass value to Calculate method using out keyword
//by default values is zero, pushed to stack with zero for area,circumference
double area, circumference;
// after Calculate method call ---> area,circumference will have calculated values which
// get radius from c1 object instance internally
// area,circumference are pushed to stack with calculated values
// reference value is printed here in area ,circumference.
c1.Calculate(out area,out circumference);
Console.WriteLine("Area: " + area);
Console.WriteLine("Circumference: " + circumference);
c1.Dispose();