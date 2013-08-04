// 10. Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.

using System;

class BitPosition
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter the bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());
        int mask = 1;
        mask = mask << bitPosition;

        int addMask = number & mask;

        bool bit = addMask != 0;

        if (bit == true)
        {
            Console.WriteLine("The bit in the position is 1: true");
        }
        else
        {
            Console.WriteLine("The bit in the position is not 1: false");
        }

        string numberBinary = Convert.ToString(number, 2);
        string maskBinary = Convert.ToString(mask, 2);
        string addMaskBinary = Convert.ToString(addMask, 2);

        Console.WriteLine("{0,15} : number\n{1,15} : mask\n{2,15} : addMask", numberBinary, maskBinary, addMaskBinary);
        
    }
}