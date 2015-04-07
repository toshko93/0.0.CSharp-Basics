//  Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values
//  by using some programming logic. Print the variable values before and after the exchange.

using System;

class ExchangeValues
{
    static void Main()
    {
        int numA = 5;
        int numB = 10;
        int numC;

        Console.WriteLine("The first number before swap: " + numA);
        Console.WriteLine("The second number before swap: " + numB);

        numC = numA;
        numA = numB;
        numB = numC;

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("The first number after swap: " + numA);
        Console.WriteLine("The second number after swap: " + numB);
    }
}
