// CheckCredit.cs

using System;
using static System.Console;
using System.Globalization;

class CheckCredit
{
  static void Main()
  {
      const double LIMIT = 8000;
      double price; 
    
      Write("Enter the price: ");
      price = Convert.ToDouble(ReadLine());
    
      if(price > LIMIT) 
      {
        WriteLine("You have exceeeded the credit limit");
      }
      else 
      {
        WriteLine("Approved");
      }
  }
}
