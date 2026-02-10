// Programming Exercise 2-2
using System;
using static System.Console;

class InchesToCentimeters
{
    static void Main()
    {
        double inches = 3;
        double centimeters;

        centimeters = inches * 2.54;

        WriteLine(inches + " inches is " + centimeters + " centimeters");
    }
}
