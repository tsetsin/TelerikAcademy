// 13. Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.

using System;

class NullValuesToVariables
{
    static void Main()
    {
        int? a = null;
        double? b = null;

        Console.WriteLine("a: {0} b: {1}", a, b);

        a += 5;
        b += 10; // Adding value to null variable results null!
        Console.WriteLine("a: {0} b: {1}", a, b);
    }
}