// Lottery.cs

using System;
using static System.Console;
using System.Globalization;

class Lottery {

  static void Main() {

    Random ranNumberGenerator = new Random();
    int randomNumber1;
    int randomNumber2;
    int randomNumber3;
    
    randomNumber1 = ranNumberGenerator.Next(1, 5);
    randomNumber2 = ranNumberGenerator.Next(1, 5);
    randomNumber3 = ranNumberGenerator.Next(1, 5);

    Write("Enter a digit from 1 to 4 >> ");
    int guess1 = Convert.ToInt32(ReadLine());
    
    Write("Enter a second digit from 1 to 4 >> ");
    int guess2 = Convert.ToInt32(ReadLine());
    
    Write("And finally a third digit from 1 to 4 >> ");
    int guess3 = Convert.ToInt32(ReadLine());

    int points = 0;

    if (guess1 == randomNumber1 || guess1 == randomNumber2 || guess1 == randomNumber3) {
      points++;
    }
    if (guess2 == randomNumber1 || guess2 == randomNumber2 || guess2 == randomNumber3) {
      points++;
    }
    if (guess3 == randomNumber1 || guess3 == randomNumber2 || guess3 == randomNumber3) {
      points++;
    }

    int award = 0;
    
    if (guess1 == randomNumber1 && guess2 == randomNumber2 && guess3 == randomNumber3) {
      award = 10000;
    }
    else if (points == 3) {
      award = 1000;
    }
    else if (points == 2) {
      award = 100;
    }
    else if (points == 1) {
      award = 10;
    }
    else {
      award = 0;
    }

    WriteLine("The winning combination was " + randomNumber1 + randomNumber2 + randomNumber3);
    WriteLine("You won $" + award);
  }
}
