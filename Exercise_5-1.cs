// SumFiveInts.cs

using System;
using static System.Console;
using System.Globalization;

class SumInts {

  static void Main() {
    
    string userInput;
    int i;
    double value;
    double sum = 0;

    // FOR LOOP that prompts user for input 5 times
    for (i = 0; i < 5; i++) {
      // INPUT - an integer from the user
      Write("Enter an integer: ");
      userInput = ReadLine();
      value = Convert.ToDouble(userInput);
      sum += value;
    } 
    // OUTPUT - give sum of 5 integers to the user
    WriteLine($"The sum is: {sum}");
    
  }

  
}
