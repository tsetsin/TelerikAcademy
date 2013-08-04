// 07. Write a program that finds the greatest of given 5 variables.

using System;
using System.Linq;

class GreatestNumber
{
    static void Main()
    {
        
        int number = 5;
        int[] numbersArr = new int[number];

        for (int i = 0; i < number; i++)
        {
            Console.Write("Number {0}: ", i + 1);
            numbersArr[i] = int.Parse(Console.ReadLine());
        }

        int greatestNumber = numbersArr.Max();
        Console.WriteLine("The Greatest number is: {0}", greatestNumber);

    }
}