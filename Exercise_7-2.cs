// PaintingEstimate.cs

using System;
using static System.Console;
using System.Globalization;

class PaintingEstimate
{
    public static void Main()
    {
        Write("Enter length of the room in feet >> ");
        int length = Convert.ToInt32(ReadLine());
        Write("Enter width of the room in feet >> ");
        int width = Convert.ToInt32(ReadLine());
        double cost = CalculateCost(length, width);
        WriteLine("Cost of job for {0} X {1} foot room is {2}", 
            length.ToString(), width.ToString(), cost.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }
    static double CalculateCost(int length, int width)
    {
         int area = 2 * (length + width) * 9;
         double price = area * 6;
         return price;
    }
}
