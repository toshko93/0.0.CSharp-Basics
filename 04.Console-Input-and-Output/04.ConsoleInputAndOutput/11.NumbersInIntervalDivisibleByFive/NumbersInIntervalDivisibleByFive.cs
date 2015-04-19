//  Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that 
//  the reminder of the division by 5 is 0. 
using System;

class NumbersInIntervalDivisibleByFive
{
    static void Main()
    {
        Console.Write("Enter the smaller number: ");
        int smallerNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the bigger number: ");
        int biggerNum = int.Parse(Console.ReadLine());
        int counter = 0;
        if (biggerNum < smallerNum)
        {
            Console.WriteLine("The first number should be smaller than the second!");
        }

        for (int i = smallerNum; i <= biggerNum; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}
