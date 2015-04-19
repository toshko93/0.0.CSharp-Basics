//  Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Enter sides A, B and height H of a trapezoid to find its area.");
        Console.WriteLine("A = ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("B = ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("H = ");
        int h = int.Parse(Console.ReadLine());

        int area = (a + b) / 2 * h;

        Console.WriteLine("The area of the trapezoid is: {0}", area);
    }
}
