//  Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Enter the lenght of the first side: ");
        int sideA = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the lenght of the second side: ");
        int sideB = int.Parse(Console.ReadLine());

        int area = sideA * sideB;

        Console.WriteLine("The area of the rectangle is: {0}", area);
    }
}
