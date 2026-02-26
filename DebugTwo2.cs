// This program greets the user
// and multiplies two entered values
using System;
using static System.Console;
class DebugTwo2
{
   static void Main()
   {
      // INPUT - Prompt user and/or get our data
      Write("Enter your name >> ");
      string name = ReadLine();

      Write("Hello, {0}! Enter an integer >> ", name);
      int first = Convert.ToInt32(ReadLine());

      Write("Enter another integer >> ");
      int second = Convert.ToInt32(Readline());

      // LOGIC (calculations, conditionals, data manipulation)
      int product = first * second;

      // OUTPUT
      // INDEXING - Start at zero -> 0!!!!
      WriteLine("Thank you, {0}. The product of {1} and {2} is {3}",
	            name, first, second, product);
     

   }
}
