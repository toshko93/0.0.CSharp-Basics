using System;

class AgeAfterTenYears
{
    static void Main()
    {
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine("Your age after ten years will be: " + (age + 10));
    }
}
