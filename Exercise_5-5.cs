// HomeSales.cs

using System;
using static System.Console;
using System.Globalization;

class HomeSales
{
    static void Main()
    {
        string initial;
        double sale;
        double totalD = 0;
        double totalE = 0;
        double totalF = 0;

        Write("Enter a salesperson initial >> ");
        initial = ReadLine().ToLower();

        while (initial != "z")
        {
            if (initial == "d" || initial == "e" || initial == "f")
            {
                Write("Enter amount of sale >> ");
                sale = Convert.ToDouble(ReadLine());

                if (initial == "d")
                    totalD += sale;
                else if (initial == "e")
                    totalE += sale;
                else
                    totalF += sale;
            }
            else
            {
                WriteLine("Sorry - invalid salesperson");
            }

            Write("Enter next salesperson intital or Z to quit >> ");
            initial = ReadLine().ToLower();
        }

        double grandTotal = totalD + totalE + totalF;

        WriteLine("Danielle sold {0}", totalD.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        WriteLine("Edward sold {0}", totalE.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        WriteLine("Francis sold {0}", totalF.ToString("C", CultureInfo.GetCultureInfo("en-US")));
        WriteLine("Total sales were {0}", grandTotal.ToString("C", CultureInfo.GetCultureInfo("en-US")));

        if (totalD > totalE && totalD > totalF)
            WriteLine("Danielle sold the most");
        else if (totalE > totalD && totalE > totalF)
            WriteLine("Edward sold the most");
        else if (totalF > totalD && totalF > totalE)
            WriteLine("Francis sold the most");
        else
            WriteLine("There was a tie");
    }
}
