using System;
delegate double Del(double x, double y);
class Program
{

    static double f1(double x, double y)
    {
        return (x/Math.Abs(Math.Pow(x,3) + Math.Pow(y,3)))+(y/Math.Abs(x+y));
    }
    static void Main()
    {
        Console.Write("a = ");
    double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b = ");
        double b = Convert.ToDouble(Console.ReadLine());
        Del d1 = f1;
        double z1 = Math.Pow(d1(a + Math.Sqrt(b), b - Math.Sqrt(a)), 2) - d1(1, a + b);
        Console.WriteLine("z1 = {0}", z1);
        Del d2 = delegate (double x, double y)
        {
            return (x / Math.Abs(Math.Pow(x, 3) + Math.Pow(y, 3))) + (y / Math.Abs(x + y));
        };
        double z2 = Math.Pow(d2(a + Math.Sqrt(b), b - Math.Sqrt(a)), 2) - d2(1, a + b);
        Console.WriteLine("z2 = {0}", z2);
        Del d3 = (x, y) => (x / Math.Abs(Math.Pow(x, 3) + Math.Pow(y, 3))) + (y / Math.Abs(x + y));
        double z3 = Math.Pow(d3(a + Math.Sqrt(b), b - Math.Sqrt(a)), 2) - d3(1, a + b);
        Console.WriteLine("z3 = {0}", z3);
    }
}