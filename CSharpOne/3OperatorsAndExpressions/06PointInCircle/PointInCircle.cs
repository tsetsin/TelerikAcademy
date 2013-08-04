// 06. Write an expression that checks if given point (x, y) is within a circle K(0, 5).

using System;

class PointInCircle
{
        static void Main()
        {
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter y: ");
            int y = int.Parse(Console.ReadLine());

            bool isWithin = (x * x) + (y * y) <= 5 * 5;

            {
                if (isWithin == true)
                {
                    Console.WriteLine("The point is in the circle");
                }
                else
                {
                    Console.WriteLine("The point is not in the circle");
                }
            }
        }
}