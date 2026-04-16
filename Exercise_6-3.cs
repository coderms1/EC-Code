//Write a program named TemperaturesComparison
//that allows a user to input five daily Fahrenheit
//temperatures that must range from −30 to 130.
//If a temperature is out of range, require the
//user to reenter it. If no temperature is lower than any
//previous one, display a message Getting warmer.
//If every temperature is lower than the previous one,
//display a message Getting cooler.
//If the temperatures are not entered in either ascending
//or descending order, display a message It’s a mixed bag.
//Finally, display the temperatures in the order they were
//entered, and then display the average of the temperatures.
//Your program's output should look like the following:

//Getting warmer:     70   74   77   78   81
//Average: 76

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
        // constant for how many temps we want to store (keeps it easy to change later)
        const int COUNT = 5;

        // valid range for temps (anything outside this gets rejected)
        const int LOW = -30;
        const int HIGH = 130;

        // array to hold all the temps the user enters
        int[] temps = new int[COUNT];

        // loop runs COUNT times so we collect exactly 5 temps
        for (int i = 0; i < COUNT; i++) {
            // (i + 1) just makes it look nicer for the user (starts at 1 instead of 0)
            Write("Enter temperature " + (i + 1) + ": ");

            // read input and convert from string to int
            int temp = int.Parse(ReadLine());

            // keep asking until the user enters a valid temp in range
            // condition checks if it's BELOW LOW OR ABOVE HIGH
            while (temp < LOW || temp > HIGH) {
                // re-prompt if invalid (note: message order is flipped but logic still works)
                Write("Temperature must be between " + HIGH +
                " and " + LOW + ". Reenter temperature: ");

                // read again until it's valid
                temp = int.Parse(ReadLine());
            }

            // store the valid temp into the array at index i
            temps[i] = temp;
        }

        // assume both are true at first, then prove otherwise in loop
        bool gettingWarmer = true;
        bool gettingCooler = true;

        // start at index 1 so we can compare current temp to previous temp
        for (int i = 1; i < COUNT; i++) {
            // if current temp is LESS than previous, then not getting warmer
            if (temps[i] < temps[i - 1])
                gettingWarmer = false;

            // if current temp is SAME or HIGHER, then not getting cooler
            if (temps[i] >= temps[i - 1])
                gettingCooler = false;
        }

        // decide what trend message to display based on the flags
        string trend;

        if (gettingWarmer)
            trend = "Getting warmer";
        else if (gettingCooler)
            trend = "Getting cooler";
        else
            trend = "It's a mixed bag";

        // build a string of all temps (instead of printing one per line)
        string tempList = "";

        for (int i = 0; i < COUNT; i++) {
            // add a space BEFORE every number except the first one
            if (i > 0) {
                tempList += " ";
            }
            // add the actual temperature value to the string
            tempList += temps[i];
        }

        // display trend + all temps in one line
        WriteLine(trend + ": " + tempList);

        // calculate total sum of temps
        int sum = 0;
        for (int i = 0; i < COUNT; i++) {
            sum += temps[i];
        }

        // cast sum to double so we don’t lose decimal places in average
        double avg = (double)sum / COUNT;
        WriteLine("Average: " + avg);

        // this is so program doesn’t instantly close.... any key will close it
        ReadKey();
    }
}
