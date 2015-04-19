//  Write a program that gets two numbers from the console and prints the greater of them. 
//  Try to implement this without if statements. 

using System;

class NumberComparer
{
    static void Main()
    {
        Console.WriteLine("Enter 2 numbers to compare them.");
        Console.Write("Enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());
        double greaterNum = Math.Max(firstNum, secondNum);

        Console.WriteLine("The greater of the two numbers is: {0}", greaterNum);
    }
}
