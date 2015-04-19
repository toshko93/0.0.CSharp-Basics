// Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/xn.
// Use only one loop. Print the result with 5 digits after the decimal point.
using System;

class CalculatingSum
{
    static void Main()
    {
        Console.Write("Enter N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter X = ");
        int x = int.Parse(Console.ReadLine());

        int nFactorial = 1;
        double sum = 1.0;
        double toSum = 0.0;

        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
            double divider = x * i;
            toSum = nFactorial / divider;
            sum += toSum;
        }
        Console.WriteLine(sum);
    }
}
