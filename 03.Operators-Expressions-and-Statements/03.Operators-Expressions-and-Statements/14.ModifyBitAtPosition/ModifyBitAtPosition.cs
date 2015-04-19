//  We are given an integer number n, a bit value v (v=0 or 1) and a position p. 
//  Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from 
//  the binary representation of n while preserving all other bits in n. 

using System;

class ModifyBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter P = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter desired bit value: ");
        int v = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int pBit = number & mask;
        
    }
}
