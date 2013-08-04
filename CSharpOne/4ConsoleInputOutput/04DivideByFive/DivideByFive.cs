// 04. Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the remainder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class DivideByFive
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter number b: ");
        int b = int.Parse(Console.ReadLine());

        if (a < b)
        {
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("There are {0} numbers p between a and b", count);
        }
        else
        {
            Console.WriteLine("a must be smaller than b");
        }
    }
}