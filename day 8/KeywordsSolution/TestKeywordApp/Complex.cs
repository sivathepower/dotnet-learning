namespace Mathematics;
public class Complex
{
    public const double Pi = 3.14159;// CONSTANT field
    public  static readonly Complex I = new Complex(0, 1); // READONLY field ONLY ONE ASSIGNMENT
    public double Real { get; set; }
    public double Imaginary { get; set; }

    public Complex(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Overloading the + operator
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    // Overloading the - operator
    public static Complex operator -(Complex c1, Complex c2)
    {
        return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
    }

    // Overloading the * operator
    public static Complex operator *(Complex c1, Complex c2)
    {
        return new Complex(
            c1.Real * c2.Real - c1.Imaginary * c2.Imaginary,
            c1.Real * c2.Imaginary + c1.Imaginary * c2.Real);
    }

    // Overloading the / operator
    public static Complex operator /(Complex c1, Complex c2)
    {
        double denom = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
        return new Complex(
            (c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / denom,
            (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / denom);
    }

    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}