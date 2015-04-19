//  Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints 
//  them in 4 virtual columns on the console. Each column should have a width of 10 characters. 
//  The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, 
//  padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; 
//  the number c should be printed with 3 digits after the decimal point, left aligned.

using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter an integer between 0 and 500: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter a floating point number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter a second floating point number: ");
        double c = double.Parse(Console.ReadLine());

        string aInHex = Convert.ToString(a, 16).ToUpper();
        aInHex = aInHex.PadRight(10, ' ');

        string aInBin = Convert.ToString(a, 2);
        aInBin = aInBin.PadLeft(10, '0');
        string bFormated = String.Format("{0:0.##}", b);
        bFormated = bFormated.PadLeft(10, ' ');
        string cFormated = String.Format("{0:0.###}", c);
        cFormated = cFormated.PadRight(10, ' ');

        Console.WriteLine(new string('-', 50));

        string result = "|" + aInHex + "|" + aInBin + "|" + bFormated + "|" + cFormated + "|";

        Console.WriteLine(result);
    }
}
