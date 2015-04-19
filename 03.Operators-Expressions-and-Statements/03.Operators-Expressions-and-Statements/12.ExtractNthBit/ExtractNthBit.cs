//  Write an expression that extracts from given integer n the value of given bit at index p. 

using System;

class ExtractNthBit
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter P = ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int pBit = number & mask;
        if (pBit >> p == 0)
        {
            Console.WriteLine("The bit at position {0} is 0", p);
        }
        else
        {
            Console.WriteLine("The bit at position {0} is 1", p);
        }
    }
}
