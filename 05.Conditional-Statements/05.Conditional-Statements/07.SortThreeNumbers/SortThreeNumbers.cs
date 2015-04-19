//  Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. 
// Don’t use arrays and the built-in sorting functionality. 

using System;

class SortThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double numA = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double numB = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double numC = double.Parse(Console.ReadLine());
        double max = 0;
        double mid = 0;
        double min = 0;

        // First case
        if (numA > numB)
        {
            if (numB < numC)
            {
                if (numA > numC)
                {
                    max = numA;
                    mid = numC;
                    min = numB;
                }
                else if (numA < numC)
                {
                    max = numC;
                    mid = numA;
                    min = numB;
                }
                else
                {
                    max = numA;
                    mid = numC;
                    min = numB;
                }
            }
            else if (numB > numC)
            {
                max = numA;
                mid = numB;
                min = numC;
            }
            else if (numB == numC)
            {
                max = numA;
                mid = numB;
                min = numC;
            }
        }
        // Second case
        else if (numA < numB)
        {
            if (numB < numC)
            {
                max = numC;
                mid = numB;
                min = numA;
            }
            else if (numB > numC)
            {
                if (numA > numC)
                {
                    max = numB;
                    mid = numA;
                    min = numC;
                }
                else if (numA < numC)
                {
                    max = numB;
                    mid = numC;
                    min = numA;
                }
                else
                {
                    max = numB;
                    mid = numA;
                    min = numC;
                }
            }
            else if (numB == numC)
            {
                max = numB;
                mid = numC;
                min = numA;
            }
        }
        // Third case
        else if (numA == numB)
        {
            if (numA > numC)
            {
                max = numA;
                mid = numB;
                min = numC;
            }
            else if (numA < numC)
            {
                max = numC;
                mid = numB;
                min = numA;
            }
            else
            {
                max = numA;
                mid = numB;
                min = numC;
            }
        }

        Console.WriteLine("{0}  {1}  {2}", max, mid, min);
    }
}
