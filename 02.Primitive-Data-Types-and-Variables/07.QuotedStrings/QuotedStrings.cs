//  Declare two string variables and assign them with following value:

//  The "use" of quotations causes difficulties.

//  Do the above in two different ways: with and without using quoted strings. 
//  Print the variables to ensure that their value was correctly defined.

using System;

class QuotedStrings
{
    static void Main()
    {
        string variantA = "The \"use\" of quotations causes difficulties.";
        string variantB = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine("Case 1:");
        Console.WriteLine(variantA);
        Console.WriteLine("Case 2:");
        Console.WriteLine(variantB);
    }
}
