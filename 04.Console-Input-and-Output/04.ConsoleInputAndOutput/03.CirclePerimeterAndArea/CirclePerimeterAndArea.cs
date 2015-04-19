//  Write a program that reads the radius r of a circle 
//  and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter the radius of a circle: ");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * Math.Pow(radius, 2);
        string perimeterInString = String.Format("{0:0.00}", perimeter);
        string areaInString = String.Format("{0:0.00}", area);
        Console.WriteLine("Circle`s perimeter: {0}", perimeterInString);
        Console.WriteLine("Circle`s area:      {0}", areaInString);
    }
}
