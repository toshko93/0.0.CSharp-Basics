//  Write an expression that checks if given positive integer number n (n ≤ 100) is prime 
//  (i.e. it is divisible without remainder only to itself and 1). 

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if its prime: ");
        int number = int.Parse(Console.ReadLine());

        if ((number == 2) || (number == 3) || (number == 5) || (number == 7))
        {
            Console.WriteLine("The number {0} is prime.", number);
        }
        else if ((number % 2 != 0) && (number % 3 != 0) && (number % 5 != 0) && (number % 7 != 0))
        {
            Console.WriteLine("The number {0} is prime.", number);
        }
        else
        {
            Console.WriteLine("The number {0} is not prime.", number);
        }
    }
}
