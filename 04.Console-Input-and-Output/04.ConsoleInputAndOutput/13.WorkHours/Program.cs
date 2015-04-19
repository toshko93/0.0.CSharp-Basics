using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double hoursToFinish = double.Parse(Console.ReadLine());
        double daysAvailable = double.Parse(Console.ReadLine());
        double productivity = double.Parse(Console.ReadLine());

        double workDays = daysAvailable - (daysAvailable / 10);
        double workHours = workDays * 12;
        double efficientWorkHours = workHours * productivity / 100;
        double floatingNumbers = efficientWorkHours % 1;
        double roundedEfficientWorkHours = efficientWorkHours - floatingNumbers;

        double hoursWorkLeft = hoursToFinish - roundedEfficientWorkHours;

        if (hoursWorkLeft > 0)
        {
            Console.WriteLine("No");
            Console.WriteLine(-hoursWorkLeft);
        }
        else
        {
            Console.WriteLine("Yes");
            Console.WriteLine(hoursWorkLeft);
        }
    }
}
