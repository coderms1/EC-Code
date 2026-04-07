// MultiplicationTable.cs

using System;
using static System.Console;
using System.Globalization;

class MultiplicationTable {

  static void Main() {

    int num;
    int i;

    Write("Enter an integer >> ");
    num = Convert.ToInt32(ReadLine());

    for (i = 1; i <= 10; i++) {
      WriteLine($"{i} x {num} = {i * num}");
    }
    
  }
}
