//  EnterUppercaseLetters.cs

using System;
using static System.Console;
using System.Globalization;

class EnterUppercaseLetter {

  static void Main() {
    // Write your code here
    string userInput;
    char letter;

    Write("Enter an uppercase letter >> ");
    userInput = ReadLine();
    letter = Convert.ToChar(userInput); 

    while (letter != '!') {
      if (char.IsUpper(letter)) {
        WriteLine("OK");
      }
      else {
        WriteLine("Sorry - that was not an uppercase letter.");
      }
      Write("Enter an uppercase letter or ! to quit >> ");
      userInput = ReadLine();
      letter = Convert.ToChar(userInput); 
    }
  } 
}
