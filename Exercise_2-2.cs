// Programming Exercise 2-2
using System;
using static System.Console;

class InchesToCentimeters
{
    static void Main()
    {
        const double CENTIMETERS_PER_INCH = 2.54;
        
        double inches = 3;
        double centimeters = inches * CENTIMETERS_PER_INCH; 

        WriteLine(inches + " inches is " + centimeters + " centimeters");
    }
}
