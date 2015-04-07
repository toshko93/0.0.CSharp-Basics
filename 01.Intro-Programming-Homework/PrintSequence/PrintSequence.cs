using System;

class PrintSequence
{
    static void Main()
    {
        int positive = 2;
        int negative = -3;

        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(positive);
                positive += 2;
            }
            else
            {
                Console.WriteLine(negative);
                negative -= 2;
            }
        }
    }
}
