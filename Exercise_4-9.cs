// RockPaperScissors.cs

using System;
using static System.Console;
using System.Globalization;

class RockPaperScissors {

    static void Main() {

      Random ranNumberGenerator = new Random();
      int randomNumber;
      
      Write("Enter r for rock, p for paper, s for scissors: ");
      char player = Convert.ToChar(ReadLine());

      randomNumber = ranNumberGenerator.Next(1, 4);
      char computer;

      if (randomNumber == 1) {
          computer = 'r';
      }
      else if (randomNumber == 2) {
          computer = 'p';
      }
      else {
        computer = 's';
      }

      if (player == computer) {
        WriteLine("Tie!");
      }
      else if (player == 'r' && computer == 's') {
        WriteLine("You win!");
      }
      else if (player == 's' && computer == 'p') {
        WriteLine("You win!");
      }
      else if (player == 'p' && computer == 'r') {
        WriteLine("You win!");
      }
      else {
        WriteLine("You lose!");
      }
   
 }


  
}
