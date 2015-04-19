// Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops. 
using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter N = ?");
        int n = int.Parse(Console.ReadLine());
        int row = n;
        int col = n;
        int[,] matrix = new int[row, col];

        Console.WriteLine("Here is the matrix:");

        for (int i = 0; i < row; i++)
        {
            for (int u = 0; u < col; u++)
            {
                matrix[i, u] = i + u + 1;

                if (n > 5 && matrix[i, u] < 10)
                {
                    Console.Write(matrix[i, u] + "  ");
                }
                else
                {
                    Console.Write(matrix[i, u] + " ");
                }
                if (u == col - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
