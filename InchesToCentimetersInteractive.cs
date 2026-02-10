// Programming Exercise 2-3
using System;

class InchesToCentimetersInteractive
{
    static void Main()
    {
        double inches;
        double centimeters;

        Console.WriteLine("Enter inches:");
        inches = Convert.ToDouble(Console.ReadLine());

        centimeters = inches * 2.54;

        Console.WriteLine(inches + " inches is " + centimeters + " centimeters");
    }
}
