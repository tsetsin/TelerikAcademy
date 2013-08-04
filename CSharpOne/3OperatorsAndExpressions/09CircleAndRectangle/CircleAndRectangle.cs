// 09. Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class CircleAndRectangle
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());
        double circlePointX = x - 1;

        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());
        double circlePointY = y - 1;
        double circleRadius = 3;

        if ((circlePointX * circlePointX + circlePointY * circlePointY) <= (circleRadius * circleRadius))
        {
            Console.WriteLine("The point is within the circle");
        }
        else
        {
            Console.WriteLine("The point is not within the circle");
        }

        double rectangleHeight = 2;
        double rectangleWidth = 6;
        double topY = 0 + (rectangleHeight / 2.0);
        double rightX = 0 + (rectangleWidth / 2.0);
        double bottomY = 0 - (rectangleHeight / 2.0);
        double leftX = 0 - (rectangleWidth / 2.0);

        double rectanglePointX = x - (-1);
        double rectanglePointY = y - 1;

        if ((rectanglePointY < topY) && (rectanglePointY > bottomY) && (rectanglePointX < rightX) && (rectanglePointX > leftX))
        {
            Console.WriteLine("The point is within the rectangle");
        }
        else
        {
            Console.WriteLine("The point is not within the rectangle");
        }
    }
}