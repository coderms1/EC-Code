// Eggs.cs

using System;
using static System.Console;
using System.Globalization;

class Eggs
{    
  static void Main() 
  {
    // INPUT 
    int chicken1 = 30;
    int chicken2 = 34;
    int chicken3 = 32;
    int chicken4 = 31;
    // LOGIC
    int totalNumEggs = chicken1 + chicken2 + chicken3 + chicken4;
    int dozen = totalNumEggs / 12;
    int eggsLeft = totalNumEggs % 12;
    // OUTPUT
    WriteLine(totalNumEggs + " eggs is " + dozen + " dozen and " + eggsLeft + " eggs.");
    
  }
}
