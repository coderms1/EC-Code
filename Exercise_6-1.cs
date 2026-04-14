// ArrayDemo.cs

using System;
using static System.Console;
using System.Globalization;

class ArrayDemo {

  static void Main() {

    int[] numbers = {7, 6, 3, 2, 10, 8, 4, 5, 9, 1}
    int choice;

    do {
        WriteLine("Menu:");
        //choice 1
        WriteLine("1 - View first to last");
        //choice 2
        WriteLine("2 - View last to first");
        //choice 3
        WriteLine("3 - View specific position");
        //choice 4
        WriteLine("4 - Quit");

        choice = Convert.ToInt32(ReadLine());

        if (choice == 1) {
            // first to last 
            for (int i = 0; i < numbers.Length; i++) {
                Write(numbers[i] + " ");
            }
        }
        else if (choice == 2) {
            // last to first
            for (int i = numbers.Length - 1; i >= 0; i--) {
                Write(numbers[i] + " ");
            }
        }
        // user choice
        else if (choice == 3) {
          Write("Enter a number 0-9: ");
          int spot = Convert.ToInt32(ReadLine());

            if (spot >= 0 && spot < numbers.Length) {
              WriteLine($"Position: {numbers[spot]}");
            }
            else {
              WriteLine("Invalid choice. ⛔");
            }
        // invalid choice       
        else if (choice != 4) {
              WriteLine("Invalid choice. ⛔");
        }
    // continue or quit program
    } while (choice != 4);
    
  }
}
