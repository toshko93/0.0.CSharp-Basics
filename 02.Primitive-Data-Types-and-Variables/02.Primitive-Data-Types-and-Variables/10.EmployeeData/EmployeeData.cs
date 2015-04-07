//  A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//  First name
//  Last name
//  Age (0...100)
//  Gender (m or f)
//  Personal ID number (e.g. 8306112507)
//  Unique employee number (27560000…27569999)

//  Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
//  Use descriptive names. Print the data at the console.


using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Todor";
        string lastName = "Atanasov";
        byte age = 21;
        char gendre = 'm';
        string personalID = "8306112507";
        string uniqueEmployeeNumber = "27562469";

        Console.WriteLine("Name: {0} {1}", firstName, lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gendre: " + gendre);
        Console.WriteLine("Personal ID: " + personalID);
        Console.WriteLine("Unique Employee Number: " + uniqueEmployeeNumber);
    }
}
