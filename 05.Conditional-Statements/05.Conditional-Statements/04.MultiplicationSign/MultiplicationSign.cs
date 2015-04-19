//  Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
// Use a sequence of if operators. 

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int numA = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int numB = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int numC = int.Parse(Console.ReadLine());
        int negativeCounter = 0;

        if (numA == 0 || numB == 0 || numC == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            if (numA < 0)
            {
                negativeCounter += 1;
            }
            if (numB < 0)
            {
                negativeCounter += 1;
            }
            if (numC < 0)
            {
                negativeCounter += 1;
            }


            if (negativeCounter % 2 == 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
    }
}
