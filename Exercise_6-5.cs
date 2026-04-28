// DeliveryCharges.cs

using System;
using static System.Console;
using static System.Array;
using System.Globalization;

class DeliveryCharges
{
    static void Main()
    {
        string[] zips = {"12789", "54012", "54481", "54982", 
        "60007", "60103", "60187", "60188", "71244", "90210"};
        double[] prices = {2.40, 3.00, 3.50, 4.00, 4.50, 
        5.00, 5.25, 5.75, 6.10, 10.00};
        string userInput;
        bool zipGood = false;
        Write("Enter a zip code: ");
        userInput = ReadLine();
        for (int i = 0; i < zips.Length; i++) {
            if (userInput == zips[i])
            {
                WriteLine("Delivery to {0} ok. Delivery charge is {1}", 
                    userInput, 
                    prices[i].ToString("C", CultureInfo.GetCultureInfo("en-US")));
                zipGood = true;
                break;
            }
            if (!zipGood)
            {
                WriteLine("Sorry - no delivery to {0}", userInput);
            }
        }
    }
}
