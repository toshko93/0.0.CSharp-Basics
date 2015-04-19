//  Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 
//  and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter parameters of a quadratic equation to find its root.");
        Console.Write("A = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("B = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("C = ");
        double c = double.Parse(Console.ReadLine());

        double d = b * b - (4 * a * c);


        if (d > 0)
        {
            double x1 = (-b - Math.Sqrt(d)) / (2 * a);
            double x2 = (-b + Math.Sqrt(d)) / (2 * a);

            Console.WriteLine("The equation has 2 real roots: X1 = {0} and X2 = {1}", x1, x2);
        }
        else if (d == 0)
        {
            double x = -b / (2 * a);

            Console.WriteLine("The equation has 1 real root: X = {0}", x);
        }
        else
        {
            Console.WriteLine("The equation doesn`t have real roots.");
        }
    }
}
