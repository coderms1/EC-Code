// ConvertMilesToKilometers.cs

using System;
using static System.Console;
using System.Globalization;

class ConvertMilesToKilometers
{
    static void Main()
    {
        Write("Enter the number of miles >> ");
        double miles = Convert.ToDouble(ReadLine());
        double kilos = ConvertToKilometers(miles);
        WriteLine("{0} miles is {1} kilometers", miles.ToString(), kilos.ToString());
    }

    static public double ConvertToKilometers(double miles)
    {
        return miles * 1.60934;
    }
}
