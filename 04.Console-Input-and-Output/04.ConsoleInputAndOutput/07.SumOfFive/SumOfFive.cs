//  Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;
using System.Linq;

class SumOfFive
{
    static void Main()
    {
        Console.Write("Enter 5 numbers on a single line separated by a space: ");
        string input = Console.ReadLine();
        double[] numbers = input.Split(' ').Select(n => Convert.ToDouble(n)).ToArray();

        double sum = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4];

        Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}", numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], sum);
    }
}