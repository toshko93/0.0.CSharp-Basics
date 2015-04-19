//  Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).

using System;

class PointInCircle
{
    static void Main()
    {
        Console.WriteLine("We have a circle with coordinates (0, 0) and with r = 2.");
        Console.WriteLine("Enter the coordinates X and Y of a point.");
        Console.Write("X = ");
        double xOfPoint = double.Parse(Console.ReadLine());
        Console.Write("Y = ");
        double yOfPoint = double.Parse(Console.ReadLine());
        double r = 2;
        double x = 0;
        double y = 0;

        if (Math.Pow((xOfPoint - x), 2) + Math.Pow((yOfPoint - y), 2) <= r * r)
        {
            Console.WriteLine("The point with coordinates ({0}, {1}) is in the circle.", xOfPoint, yOfPoint);
        }
        else
        {
            Console.WriteLine("The point with coordinates ({0}, {1}) is outside the circle.", xOfPoint, yOfPoint);
        }
    }
}
