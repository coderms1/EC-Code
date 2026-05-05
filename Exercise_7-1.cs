// SalesLetter.cs

using System;
using static System.Console;
using static System.Array;
using System.Globalization;

class SalesLetter
{
    static void Main()
    {
        WriteLine("From");
        DisplayContactInfo();
        WriteLine("___________________");
        WriteLine("Dear Client, \nWe want to provide you good service.\nFeel free to contact us at any time.");
        DisplayContactInfo();
        WriteLine("   **********");
        WriteLine("Looking forward to a long relationship.");
        DisplayContactInfo();
    }

    static void DisplayContactInfo()
    {
        WriteLine("C# Company");
        WriteLine("Phone: 555-1234   Cell: 555-0912");
        WriteLine("Email: csharpcomany@csharp.com");
        WriteLine("One the Web at www.csharpcompanyforyou.com");
    }
}
