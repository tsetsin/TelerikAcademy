// 01. Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class IntegerSum
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter number c: ");
        int c = int.Parse(Console.ReadLine());

        int sum = a + b + c;

        Console.WriteLine("a + b + c = {0}", sum);
    }
}