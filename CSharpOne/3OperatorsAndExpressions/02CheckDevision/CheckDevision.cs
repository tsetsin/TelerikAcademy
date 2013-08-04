// 02. Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

using System;

class CheckDevision
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        bool check = (number % 5 == 0) && (number % 7 == 0);
        Console.WriteLine("{0}", check);
    }
}