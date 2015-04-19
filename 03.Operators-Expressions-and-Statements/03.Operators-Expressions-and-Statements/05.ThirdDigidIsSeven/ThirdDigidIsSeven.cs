//  Write an expression that checks for given integer if its third digit from right-to-left is 7. 

using System;

class ThirdDigidIsSeven
{
    static void Main()
    {
        Console.WriteLine("Enter a number to check if its third digit (right-to-left) is 7: ");
        int number = int.Parse(Console.ReadLine());

        int thirdDigit = number / 100;

        if (thirdDigit % 10 == 7)
        {
            Console.WriteLine("The third digit (right-to-left) is 7.");
        }
        else
        {
            Console.WriteLine("The third digit (right-to-left) is NOT 7.");
        }
    }
}
