//  Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. 

using System;

class DivisibleByFiveAndSeven
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if its divisible by 5 and 7: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 5 == 0 && number % 7 == 0)
        {
            Console.WriteLine("The number {0} is divisible by 5 and 7 without remainder.", number);
        }
        else
        {
            Console.WriteLine("The number {0} is not divisible by 5 and 7 without remainder.", number);
        }
    }
}
