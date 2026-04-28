// CheckZips.cs

using System;
using static System.Console;
using static System.Array;

class CheckZips
{
    static void Main()
    {
        string[] zips = {"12789", "54012", "54481", "54982", 
        "60007", "60103", "60187", "60188", "71244", "90210"};
        string userZips;
        bool zipGood = false;
        Write("Enter a zip code: ");
        userZips = ReadLine();
        for (int i = 0; i < zips.Length; i++) {
            if (userZips == zips[i])
            {
                zipGood = true;
            }
        }
        if (zipGood) {
                WriteLine("Delivery to " + userZips + " ok.");
            }
        else {
                WriteLine("Sorry - no delivery to " + userZips + ".");
            }
    }
}

