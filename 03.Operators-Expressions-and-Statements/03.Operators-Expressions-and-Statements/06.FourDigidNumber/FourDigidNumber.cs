//  Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//  -Calculates the sum of the digits (in our example 2+0+1+1 = 4).
//  -Prints on the console the number in reversed order: dcba (in our example 1102).
//  -Puts the last digit in the first position: dabc (in our example 1201).
//  -Exchanges the second and the third digits: acbd (in our example 2101).
//  The number has always exactly 4 digits and cannot start with 0.

using System;

class FourDigidNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a four-digit number. The program will do some operations with it.");
        int number = int.Parse(Console.ReadLine());

        //Taking the single number
        int singles = number % 10;

        //Taking tens number
        int remainderForTens = number / 10;
        int tens = remainderForTens % 10;
        
        //Taking hundrets number
        int remainderForHundreds = number / 100;
        int hundrets = remainderForHundreds % 10;
        
        //Taking thousands number
        int thousands = number / 1000;

        int sumOfAllDigits = singles + tens + hundrets + thousands;

        Console.WriteLine("Number: {0}", number);
        Console.WriteLine("Sum of all digits: {0} + {1} + {2} + {3} = {4}", thousands, hundrets, tens, singles, sumOfAllDigits);
        Console.WriteLine("The number in reversed order: {0}{1}{2}{3}", singles, tens, hundrets, thousands);
        Console.WriteLine("The last digit in first position: {0}{1}{2}{3}", singles, thousands, hundrets, tens);
        Console.WriteLine("The second and third digits swaped: {0}{1}{2}{3}", thousands, tens, hundrets, singles);
    }
}
