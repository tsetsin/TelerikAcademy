// 03. A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
// Write a program that reads the information about a company and its manager and prints them on the console.

using System;

class CompanyInfo
{
    static void Main()
    {
       
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();
        
        Console.Write("Company phone: ");
        string companyPhone = Console.ReadLine();

        Console.Write("Company fax: ");
        string companyFax = Console.ReadLine();

        Console.Write("Company website: ");
        string companyWebsite = Console.ReadLine();

        Console.Write("Company manager: ");
        string companyManager = Console.ReadLine();

        Console.Write("Manager ID: ");
        string managerID = Console.ReadLine();

        Console.Write("Manager first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Manager last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Manager age: ");
        byte managerAge = byte.Parse(Console.ReadLine());

        Console.Write("Manager phone: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine("\nCompany Details:\nName:\t{0}\nAddress:\t{1}\nPhone Number:\t{2}\nFax Number:\t{3}\nWebsite:\t{4}\nManagerID:\t{5}\n", companyName, companyAddress, companyPhone, companyFax, companyWebsite, companyManager);
        Console.WriteLine("\nManager Details:\nFirst Name:\t{0}\nLast Name:\t{1}\nAge:\t{2}\nPhone Number:\t{3}", managerFirstName, managerLastName, managerAge, managerPhone);

    }
}