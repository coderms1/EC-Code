// DailyTemps.cs

using System;
using static System.Console;
using System.Globalization; 

class DailyTemps {

  static void Main() {
    string userInput;
    double temp, avgTemp;
    double tempSum = 0;
    double tempCount = 0;

    do {
      Write("Enter temperature or type 999 to exit: ");
      userInput = ReadLine();
      temp = Convert.ToDouble(userInput);

      if (temp == 999) {
          break;
      }
      
      if (temp >= -20 && temp <= 130) {
        tempSum += temp; 
        tempCount += 1;
      }
      else {
        WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature.");
      }
      
    } while (true);

    avgTemp = tempSum / tempCount;
    WriteLine($"Number of temperatures: {tempCount}.");
    WriteLine($"Average temperature: {avgTemp}.");
    ReadKey();
  }
  
}


