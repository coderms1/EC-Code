// SumInts.cs

using System;
using static System.Console;
using System.Globalization;

class SumInts {

  static void Main() {

    // Write your code here
    int num;
    int sum = 0;

    Write("Enter an integer (999 to quit): "); 
    num = Convert.ToInt32(ReadLine());

    while (num != 999) {
      sum += num;
      Write("Enter an integer (999 to quit): "); 
      num = Convert.ToInt32(ReadLine());
    }
    WriteLine($"The sum is: {sum}");
     
  }

  
}
