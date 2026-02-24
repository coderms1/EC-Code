// HoursAndMinutes.cs

using System;
using static System.Console;
using System.Globalization;

class HoursAndMinutes 
{  
  static void Main()
  {
    // INPUT (gather the info we're gonna use)
    int minutes = 197;
    // LOGIC (calculate results)
    int hours = minutes / 60;
    int minsLeft = minutes % 60;
    // OUTPUT (display results to user)
    WriteLine(minutes + " minutes is " + hours " hours and " + minsLeft + " minutes.");
  }
}
