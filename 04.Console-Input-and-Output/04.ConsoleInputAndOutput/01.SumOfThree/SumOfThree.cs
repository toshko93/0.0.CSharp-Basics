//  Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class SumOfThree
{
    static void Main()
    {
        Console.WriteLine("Enter in three numbers to see their sum.");
        Console.Write("A = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("C = ");
        int c = int.Parse(Console.ReadLine());

        int sum = a + b + c;

        Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, sum);
    }
}
