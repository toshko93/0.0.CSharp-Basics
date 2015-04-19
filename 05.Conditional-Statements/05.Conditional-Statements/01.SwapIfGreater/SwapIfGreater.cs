//  Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one.
// As a result print the values a and b, separated by a space. 

using System;

class SwapIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter the first variable: ");
        double numA = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second variable: ");
        double numB = double.Parse(Console.ReadLine());

        if (numA < numB)
        {
            Console.WriteLine(numA + " " + numB);
        }
        else
        {
            Console.WriteLine(numB + " " + numA);
        }
    }
}
