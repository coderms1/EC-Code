// TemperaturesComparison.cs


using System;
using static System.Console;
using static System.Array;
using static System.Math;
using System.Globalization;

class TemperaturesComparison
{
    static void Main()
    {
        // How many temperatures
        const int COUNT = 5;
        // Low & High Range
        const int LOW = -30;
        const int HIGH = 130;
        // Array of our temperatures
        int[] temps = new int[COUNT];
        
        // Loop: COUNT many times collecting the temps from user
        for (int i = 0; i < COUNT; i++)
        {
            Write("Enter temperature " + (i + 1) + ": ");
            int temp = int.Parse(ReadLine());

            while (temp < LOW || temp > HIGH)
            {
                Write("Temperature must be between " + HIGH + 
                " and " + LOW + ". Reenter temperature: ");
                temp = int.Parse(ReadLine());
            }
            // Store temp
            temps[i] = temp;
        }
        // Figure out the trend of the temps
        bool gettingWarmer = true;
        bool gettingCooler = true;

        for (int i = 1; i < COUNT; i++)
        {
            if (temps[i] < temps[i - 1])
                gettingWarmer = false;
            if (temps[i] >= temps[i - 1])
                gettingCooler = false;
        }
        string trend;
        if (gettingWarmer)
            trend = "Getting warmer";
        else if (gettingCooler)
            trend = "Getting cooler";
        else
            trend = "It's a mixed bag";

        string tempList = "";
        for (int i = 0; i < COUNT; i++)
        {
            if (i > 0) {
                tempList += " ";
            }
            tempList += temps[i];
        }
        WriteLine(trend + ": " + tempList);
        int sum = 0;
        for (int i = 0; i < COUNT; i++)
        {
            sum += temps[i];
        }
        double avg = (double)sum / COUNT;
        WriteLine("Average: " + avg);
        ReadKey();
    }
}
