//  Write a program that finds the biggest of five numbers by using only five if statements. 

using System;

class BiggestOfFive
{
    static void Main()
    {
        int[] numbers = new int[5];
        Console.Write("Number A = ");
        numbers[0] = int.Parse(Console.ReadLine());
        Console.Write("Number B = ");
        numbers[1] = int.Parse(Console.ReadLine());
        Console.Write("Number C = ");
        numbers[2] = int.Parse(Console.ReadLine());
        Console.Write("Number D = ");
        numbers[3] = int.Parse(Console.ReadLine());
        Console.Write("Number E = ");
        numbers[4] = int.Parse(Console.ReadLine());
        int maxNumber = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }
        }
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("The greatest number is: {0}", maxNumber);
    }
}
