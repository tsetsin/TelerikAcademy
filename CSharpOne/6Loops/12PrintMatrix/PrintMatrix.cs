﻿// 12. Write a program that reads from the console a positive integer 
// number N (N < 20) and outputs a matrix like the following:

// N = 3    N = 4
// 1 2 3    1 2 3 4
// 2 3 4    2 3 4 5
// 3 4 5    3 4 5 6
//          4 5 6 7

using System;

class PrintMatrix
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 1 + i; j <= n + i; j++)
            {
                Console.Write(j+" ");
            }
            Console.WriteLine();
        }
    }
}