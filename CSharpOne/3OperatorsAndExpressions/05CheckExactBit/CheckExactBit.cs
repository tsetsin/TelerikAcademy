// 05. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

using System;

class CheckExactBit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int movedBy3 = number >> 3;
        bool isOne = movedBy3 % 2 == 1;

        {
            if (isOne == true)
            {
                Console.WriteLine("The bit 3 is 1");
            }
            else
            {
                Console.WriteLine("The bit 3 is 0");
            }
        }
    }
}