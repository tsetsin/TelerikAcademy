﻿// 09. Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class Fibonacci
{
    static void Main()
    {
        decimal firstNumber = 1;
        decimal secondNumber = 0;
        decimal thirdNumber = 0;

        for (int i = 0; i <= 100; i++)
        {
            thirdNumber = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = thirdNumber;
            Console.WriteLine(i + ": " + thirdNumber);
        }
    }
}