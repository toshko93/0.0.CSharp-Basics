//  Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
//  in given integer number n has value of 1.

using System;

class CheckBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter P = ");
        int p = int.Parse(Console.ReadLine());
        bool isOne = false;
        int mask = 1 << p;
        int pBit = number & mask;
        if (pBit >> p == 1)
        {
            isOne = true;
        }

        Console.WriteLine(isOne);
    }
}
