// 11. Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

using System;

class IntegerExchange
{
    static void Main()
    {

        int var1 = 5;
        int var2 = 10;
        int var3;

        var3 = var1;
        var1 = var2;
        var2 = var3;

        Console.WriteLine("Original Values:\na = 5\nb = 10\n\nNew Values:\na = {0}\nb = {1}", var1, var2);
    }
}