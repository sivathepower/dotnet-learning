using Drawing;

Line l1=new Line(new Point(1,2),new Point(3,4));
l1.Draw();
l1.Dispose();

Line l2 = new Line(new Point(5,6),new Point(7,8),Color.Red,5);
l2.Draw();
l2.Dispose();

Console.WriteLine("End of Main method");