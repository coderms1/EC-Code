// HomeSales.cs

using System;
using static System.Console;
using System.Globalization;

class HomeSales
{  
    static void Main() {

      string initial;
      double sale;
      double dSales = 0;
      double eSales = 0;
      double fSales = 0;

      Write("Enter a salesperson initial >> ");
      initial = ReadLine().ToLower();

      while (initial != "z") {

        if (initial == "d" || initial == "e" || initial == "f") {
            Write("Enter amount of sale >> ");
            sale = Convert.ToDouble(ReadLine());

            if (initial == "d") {
              dSales += sale;
            }

            else if (initial == "e") {
              eSales += sale;
            }
            else {
              fSales += sale;
            } 
        }
        else {
          WriteLine("Sorry - invalid salesperson");
        }
        Write("Enter next salesperson initial or Z to quit >> ");
        initial = ReadLine().ToLower();
      }

      double totalSales = dSales + eSales + fSales;

      WriteLine("Danielle sold {0}", dSales.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Edward sold {0}", eSales.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Francis sold {0}", fSales.ToString("C", CultureInfo.GetCultureInfo("en-US")));
      WriteLine("Total sales were {0}", totalSales.ToString("C", CultureInfo.GetCultureInfo("en-US")));

      if (dSales > eSales && dSales > fSales) {
        WriteLine("Danielle sold the most");
      }
      else if (eSales > dSales && eSales > fSales) {
        WriteLine("Edward sold the most");
      }
      else if (fSales > dSales && fSales > eSales) {
        WriteLine("Francis sold the most");
      else {
        WriteLine("There was a tie");
      }
}
