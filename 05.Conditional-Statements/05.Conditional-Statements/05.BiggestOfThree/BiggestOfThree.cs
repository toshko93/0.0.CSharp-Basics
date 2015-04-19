//  Write a program that finds the biggest of three numbers. 

using System;

class BiggestOfThree
{
    static void Main()
    {
        Console.Write("Number A = ");
        int numA = int.Parse(Console.ReadLine());
        Console.Write("Number B = ");
        int numB = int.Parse(Console.ReadLine());
        Console.Write("Number C = ");
        int numC = int.Parse(Console.ReadLine());
        int maxNumber = numA;

        if (numB > maxNumber)
        {
            maxNumber = numB;

            if (numC > maxNumber)
            {
                maxNumber = numC;
            }
        }
        else if (numC > maxNumber)
        {
            maxNumber = numC;
        }

        Console.WriteLine(maxNumber);
    }
}
