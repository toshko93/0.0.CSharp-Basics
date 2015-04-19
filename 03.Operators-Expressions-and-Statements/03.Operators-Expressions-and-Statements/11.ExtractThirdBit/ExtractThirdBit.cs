//  Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//  The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. 

using System;

class ExtractThirdBit
{
    static void Main()
    {
        Console.WriteLine("Enter an integer to find its third bit: ");
        int number = int.Parse(Console.ReadLine());
        int mask = 1 << 3;
        int thirdBit = number & mask;
        if (thirdBit >> 3 == 0)
        {
            Console.WriteLine("The third bit is 0");
        }
        else
        {
            Console.WriteLine("The third bit is 1");
        }
    }
}
