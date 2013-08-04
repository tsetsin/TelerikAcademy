﻿// 10. A marketing firm wants to keep record of its employees.
// Each record would have the following characteristics – first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999).
// Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.

using System;

class EmployeeRecord
{
    static void Main()
    {
        string firstName, familyName;
        byte age;
        char gender;
        int idNumber;
        ushort uniqueEmpNumber;

        firstName = "Georgi";
        familyName = "Georgiev";
        age = 30;
        gender = 'm';
        idNumber = 123456789;
        uniqueEmpNumber = 1111;

        Console.WriteLine("Personal Information about {0} {1}:\n\nFirst Name: {0}\nFamily Name: {1}\nAge: {2}\nGender: {3}\nID Number: {4}\nUnique Employee Number: {5}", firstName, familyName, age, gender, idNumber, 27560000 + uniqueEmpNumber);
    }
}