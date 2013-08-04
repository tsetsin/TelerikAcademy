// 03. Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

using System;

class CompareFloatingPoints
{
    static void Main()
    {
        Console.WriteLine("First number:");
        float number1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Second number:");
        float number2 = float.Parse(Console.ReadLine());

        Console.WriteLine("The two numbers are: {0} and {1}", number1, number2);

        if (number1 == number2)
        {
            Console.WriteLine("The numbers are equal with a precision of 0.000001");
        }
        else
        {
            Console.WriteLine("The numbers are not equal with a precision of 0.000001");
        }
    }
}