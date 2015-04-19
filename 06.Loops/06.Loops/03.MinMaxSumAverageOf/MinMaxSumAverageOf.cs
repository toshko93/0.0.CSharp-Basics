// Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
// the sum and the average of all numbers (displayed with 2 digits after the decimal point). 
// The input starts by the number n (alone in a line) followed by n lines, each holding an integer number. 
// The output is like in the examples below.
using System;

class MinMaxSumAverageOf
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());
        double[] numbers = new double[n];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0} number: ", i + 1);
            numbers[i] = double.Parse(Console.ReadLine());
        }

        double min = numbers[0];
        double max = numbers[0];
        double sum = 0;

        // Finding minimal and maximal number
        for (int y = 0; y < numbers.Length; y++)
        {
            if (numbers[y] < min)
            {
                min = numbers[y];
            }
            else if (numbers[y] > max)
            {
                max = numbers[y];
            }
            sum += numbers[y];
        }
        double average = sum / n;

        Console.WriteLine("Minimal: {0}", min);
        Console.WriteLine("Maximal: {0}", max);
        Console.WriteLine("Sum of all: {0}", sum);
        Console.WriteLine("Average: {0}", Math.Round(average, 2));
    }
}
