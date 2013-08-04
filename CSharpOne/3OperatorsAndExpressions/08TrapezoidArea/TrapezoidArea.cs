// 08. Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter height: ");
        int height = int.Parse(Console.ReadLine());

        double area = ((a + b) / 2.0) * height;

        Console.WriteLine("The area of the trapezoid is: {0}", area);
    }
}