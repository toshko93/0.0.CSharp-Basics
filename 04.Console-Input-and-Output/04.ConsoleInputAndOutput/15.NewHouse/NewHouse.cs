using System;

class NewHouse
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int height = n;
        int width = n;
        int roofHeight = n / 2;
        int roofWidth = 1;

        int connection = n;
        
        // Building the roof
        for (int i = 0; i < roofHeight; i++)
        {
            Console.Write(new string('-', (width - roofWidth) / 2));
            Console.Write(new string('*', roofWidth));
            Console.WriteLine(new string('-', (width - roofWidth) / 2));
            roofWidth += 2;
        }

        // Connection between the roof and the body
        Console.WriteLine(new string('*', width));

        // Building the body of the house
        for (int j = 0; j < n; j++)
        {
            Console.Write('|');
            Console.Write(new string('*', width - 2));
            Console.WriteLine('|');
        }
    }
}
