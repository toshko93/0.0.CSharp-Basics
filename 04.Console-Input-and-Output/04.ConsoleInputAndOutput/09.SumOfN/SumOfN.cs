//  Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
//  Note that you may need to use a for-loop. 

using System;

class SumOfN
{
    static void Main()
    {
        Console.Write("How many numbers you want to sum: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter the {0}-th number: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
            sum += array[i];
        }
        Console.WriteLine(new string('-', 40));
        Console.WriteLine("The sum is: {0}", sum);
    }
}
