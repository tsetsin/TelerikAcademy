// 03. Write a program that finds the biggest of three integers using nested if statements.

using System;

class BiggestInteger
{
    static void Main()
    {
        Console.Write("Enter number 1: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter number 2: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter number 3: ");
        int c = int.Parse(Console.ReadLine());
        
        if ((a > b && a > c))
        {
            Console.WriteLine("{0} is the biggest number.", a);
        }
        else if (b > a && b > c)
        {
            Console.WriteLine("{0} is the biggest number.", b);
        }
        else
        {
            Console.WriteLine("{0} is the biggest number.", c);
        }
    }
}