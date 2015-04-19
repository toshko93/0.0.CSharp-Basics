//  A company has name, address, phone number, fax number, web site and manager. 
//  The manager has first name, last name, age and a phone number. 
//  Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        Console.Write("Enter company name: ");
        string companyName = Console.ReadLine();
        Console.Write("Enter company address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter company phone number: ");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Enter company fax number: ");
        string companyFaxNumber = Console.ReadLine();
        Console.Write("Enter company website: ");
        string companyWebsite = Console.ReadLine();
        Console.Write("Enter manager`s first name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter manager`s last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter manager`s age: ");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Enter manager`s phone number: ");
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine(new string('-', 40));
        Console.WriteLine("Here is the information about {0}:", companyName);
        Console.WriteLine(new string('-', 40));

        Console.WriteLine("Company name: {0}", companyName);
        Console.WriteLine("Company address: {0}", companyAddress);
        Console.WriteLine("Company phone number: {0}", companyPhoneNumber);
        Console.WriteLine("Company fax number: {0}", companyFaxNumber);
        Console.WriteLine("Company website: {0}", companyWebsite);
        Console.WriteLine("Manager`s first name: {0} {1}", managerFirstName, managerLastName);
        Console.WriteLine("Manager`s age: {0}", managerAge);
        Console.WriteLine("Manager`s phone number: {0}", managerPhoneNumber);
    }
}
