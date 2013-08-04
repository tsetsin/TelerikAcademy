// 10. Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class SumCalculation
{
    static void Main()
    {
        decimal startNumber = 1;
        decimal totalSum = 1;
        
        for (decimal j = 2; j <= 1000; j++)
        {
            startNumber = 1;
            if (j % 2 == 0)
            {
                startNumber = startNumber / j;
                startNumber = Math.Round(startNumber, 3);
            }
            else
            {
                startNumber = -(startNumber / j);
                startNumber = Math.Round(startNumber, 3);
            }
           
            totalSum = totalSum + startNumber;
        }
        Console.WriteLine("The total sum is: {0}", totalSum);
    }
}