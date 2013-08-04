// 01. Write a program that prints all the numbers from 1 to N.

using System;

class Loop1ToN
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}