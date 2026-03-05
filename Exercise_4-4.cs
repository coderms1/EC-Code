// Hurricane.cs

using System;
using static System.Console;
using System.Globalization;

class Hurricane {

  static void Main() {
    // INPUT
    Write("Enter the Wind Speed: ");
    int wind = Convert.Int32(ReadLine());

    if (wind >= 157) {
      WriteLine("This is a category 5 hurricane.");
    }
    else if (wind >= 130) {
      WriteLine("This is a category 4 hurricane.");
    }
    else if (wind >= 111) {
      WriteLine("This is a category 3 hurricane.");
    }
    else if (wind >= 96) {
      WriteLine("This is a category 2 hurricane.");
    }
    else if (wind >= 74) {
      WriteLine("This is a category 1 hurricane.");
    }
    else {
      WriteLine("This is not a hurricane.");
    }

  }
}
