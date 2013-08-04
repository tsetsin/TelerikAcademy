// 06. Declare a boolean variable called isFemale and assign an appropriate value corresponding to your gender.

using System;

class Gender
{
    static void Main()
    {
        bool isFemale = false;

        switch (isFemale)
        {
            case true:
                Console.WriteLine("female");
                break;
            case false:
                Console.WriteLine("male");
                break;
        }
    }
}