// 02. Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class CircleAreaPerimeter
{
    static void Main()
    {
        Console.Write("Enter circle radius r: ");
        int radius = int.Parse(Console.ReadLine());

        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;

        Console.WriteLine("Circle Radius r = {0} \nCircle Perimeter P = {1}\nCircle Area S = {2}", radius, perimeter, area);
    }
}