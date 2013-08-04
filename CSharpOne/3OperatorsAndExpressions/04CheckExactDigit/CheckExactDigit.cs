// 04. Write an expression that checks for given integer if its third digit (right to left) is 7. E.g. 1732 -> true.

using System;

class CheckExactDigit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int dividedBy100 = number / 100;
        int remainder = (Math.Abs(dividedBy100) % 10);
        {
            if (remainder == 7)
            {
                Console.WriteLine("The third digit is 7 - true");
            }
            else
            {
                Console.WriteLine("The third digit is not 7 - false");
            }
        }
    }
}