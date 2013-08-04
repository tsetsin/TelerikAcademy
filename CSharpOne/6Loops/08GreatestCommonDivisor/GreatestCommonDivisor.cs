﻿// 08. Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).

using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.Write("Enter number a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number b: ");
        double b = double.Parse(Console.ReadLine());

        if (a < b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        double result;
        double resultRemainder;

        Console.WriteLine();
        while (true)
        {
            result = a / b;
            resultRemainder = a % b;
            if (resultRemainder != 0)
            {
                Console.WriteLine("{0} : {1} = {2} ; reminder = {3}", a, b, result, resultRemainder);
                a = b;
                b = resultRemainder;
            }
            else
            {
                Console.WriteLine("The Greatest Common Divisor is: {0}", b);
                break;
            }
        }
    }
}