//  Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of 
//  the rectangle R(top=1, left=-1, width=6, height=2). 

using System;

class PointInCircleOutRect
{
    static void Main()
    {
        Console.WriteLine("We have a circle with center (1, 1) and radius = 1,5 and a rectangle with top left corner (-1, 1), width = 6 and height = 2.");
        Console.WriteLine("Enter (X, Y) coordinates of a point.");
        Console.Write("Enter X = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter Y = ");
        double y = double.Parse(Console.ReadLine());
        
        double circleX = 1;
        double circleY = 1;
        double circleR = 1.5;
        
        bool inCircle = false;
        bool inRectangle = false;

        //Check if point is in the circle
        if (Math.Pow((x - circleX), 2) + Math.Pow((y - circleY), 2) <= circleR * circleR)
        {
            inCircle = true;
        }
        //Check if the point is inside the rectangle
        if (x >= -1 && x <= 5 && y <= 1 && y >= -1)
        {
            inRectangle = true;
        }
        
        //Conclusion
        if (inCircle == true && inRectangle == false)
        {
            Console.WriteLine("The point is in the circle and outside the rectangle.");
        }
        else if (inCircle == true && inRectangle == true)
        {
            Console.WriteLine("The point is in the circle but inside the rectangle too.");
        }
        else
        {
            Console.WriteLine("The point is outside the circle");
        }
    }
}
