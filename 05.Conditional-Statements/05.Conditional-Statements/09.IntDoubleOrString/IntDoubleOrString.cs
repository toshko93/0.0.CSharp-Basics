//  Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
// If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end.
// Print the result at the console. Use switch statement. 

using System;

class IntDoubleOrString
{
    static void Main()
    {
        Console.WriteLine("Choose a type:");
        Console.WriteLine("1 --> int");
        Console.WriteLine("2 --> double");
        Console.WriteLine("3 --> string");
        int type = int.Parse(Console.ReadLine());
        
        switch (type)
        {
            case 1: 
                Console.Write("Enter a integer: ");
                int intVar = int.Parse(Console.ReadLine());
                intVar += 1;
                Console.WriteLine(intVar);
                break;

            case 2:
                Console.Write("Enter a double: ");
                double doubleVar = double.Parse(Console.ReadLine());
                doubleVar += 1;
                Console.WriteLine(doubleVar);
                break;

            case 3:
                Console.Write("Enter a string: ");
                string stringVar = Console.ReadLine();
                stringVar += "*";
                Console.WriteLine(stringVar);
                break;

            default:
                Console.WriteLine("Not a valid type!");
                break;
        }
    }
}
