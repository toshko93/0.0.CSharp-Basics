//  The gravitational field of the Moon is approximately 17% of that on the Earth. 
//  Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class MoonGravity
{
    static void Main()
    {
        Console.WriteLine("The gravitational field of the Moon is approximately 17% of that on the Earth.");
        Console.WriteLine("Enter your weight to see how much it would be on the moon: ");

        int weight = int.Parse(Console.ReadLine());
        int result;

        result = (weight * 17) / 100;

        Console.WriteLine("Your weight on the Moon would be: {0}", result);
    }
}

