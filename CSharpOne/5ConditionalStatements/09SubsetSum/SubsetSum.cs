﻿// 09. We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.

using System;

class SubsetSum
{
    static void Main()
    {
        int intCount = 5;
        int[] intArray = new int[intCount];

        for (int i = 0; i < intCount; i++)
        {
            Console.Write("Number {0}: ", i + 1);
            intArray[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        int subsetCount = 0;

        for (int i = 0; i < intCount; i++)
        {
            for (int j = i + 1; j < intCount; j++)
            {
                sum = intArray[i] + intArray[j];
                if (sum == 0)
                {
                    subsetCount++;
                }
                for (int k = j + 1; k < intCount; k++)
                {
                    sum = sum + intArray[k];
                    if (sum == 0)
                    {
                        subsetCount++;
                    }
                    for (int l = k + 1; l < intCount; l++)
                    {
                        sum = sum + intArray[l];
                        if (sum == 0)
                        {
                            subsetCount++;
                        }
                        for (int m = l + 1; m < intCount; m++)
                        {
                            sum = sum + intArray[m];
                            if (sum == 0)
                            {
                                subsetCount++;
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine("There are {0} sums of subsets that are equal to Zero!", subsetCount);
    }
}