//  Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence
//  (at a single line, separated by spaces).
using System;

class FibbonaciNumbers
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int firstNumber = 0;
        int secondNumber = 1;
        int currentNum = secondNumber;
        int prevNum = firstNumber;
        int nextNum;
        string output = "";

        if (n > 2)
        {
            output = "0 1 ";
            for (int i = 2; i < n; i++)
            {
                nextNum = prevNum + currentNum;
                output += nextNum.ToString() + " ";
                prevNum = currentNum;
                currentNum = nextNum;
            }
            Console.WriteLine(output);
        }
        else if (n == 2)
        {
            Console.WriteLine("0 1");
        }
        else if (n == 1)
        {
            Console.WriteLine("0");
        }
    }
}
