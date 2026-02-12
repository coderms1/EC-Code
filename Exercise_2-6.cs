// MoveEstimator.cs

using System;
using static System.Console;
using System.Globalization;

class MoveEstimator 
{  
  static void Main()
  {
  
  WriteLine("Enter number of hours for job: ");
  double hours = Convert.ToDouble(ReadLine());
  WriteLine("Enter number of miles for job: ");
  double miles = Convert.ToDouble(ReadLine());

  double hrCharge = hours * 150;
  double mileCharge = miles * 2;
  double totalCharge = hrCharge + mileCharge + 200;

  WriteLine("For a move taking {0} hours and going {1} miles the estimate is {3}", 
            hours, miles, totalCharge.ToString("C", CultureInfo.GetCultureInfo("en-US")));
  }

}
