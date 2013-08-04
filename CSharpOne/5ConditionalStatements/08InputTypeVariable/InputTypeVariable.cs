// 08. Write a program that, depending on the user's choice inputs int, double or string variable.
// If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. The program must show the value of that variable as a console output. Use switch statement.

using System;

class InputTypeVariable
{
    static void Main()
    {
        Console.WriteLine("Enter the type of the variable. 1 for int, 2 for double and 3 for string: ");
        byte choice = byte.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.Write("Enter the the variable: ");
                int intChoice = int.Parse(Console.ReadLine());
                Console.WriteLine(intChoice + 1);
                break;
            case 2:
                Console.Write("Enter the the variable: ");
                double doubleChoice = double.Parse(Console.ReadLine());
                Console.WriteLine(doubleChoice + 1);
                break;
            case 3:
                Console.Write("Enter the the variable: ");
                string stringChoice = Console.ReadLine();
                Console.WriteLine(stringChoice + "*");
                break;
            default: Console.WriteLine("Invalid input!");
                break;
        }
    }
}