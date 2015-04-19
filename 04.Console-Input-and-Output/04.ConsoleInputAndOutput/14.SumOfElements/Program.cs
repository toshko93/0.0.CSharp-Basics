using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] numbers = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        int sumOfAll = 0;

        for (int i = 0; i < numbers.Length; i++)
		{
                sumOfAll += numbers[i];
		}

        int currentDifference = Int32.MaxValue;
        int minimalDifference = currentDifference;
        bool isElement = false;

        for (int j = 0; j < numbers.Length; j++)
        {
            currentDifference = sumOfAll - (2 * numbers[j]);
            if (minimalDifference > currentDifference)
            {
                minimalDifference = currentDifference;
            }

            if (currentDifference == 0)
            {
                isElement = true;
                Console.WriteLine("Yes, sum={0}", numbers[j]);
                break;
            }
        }

        if (!isElement)
        {
            Console.WriteLine("No, diff={0}", Math.Abs(minimalDifference));
        }
    }
}
