// ArrayDemo.cs

using System;
using static System.Console;

class ArrayDemo
{
    static void Main()
    {
        int[] numbers = { 7, 6, 3, 2, 10, 8, 4, 5, 9, 1 };
        int choice;

        do
        {
            WriteLine("\nArray Menu");
            WriteLine("(1) View list first to last");
            WriteLine("(2) View list last to first");
            WriteLine("(3) View a specific position");
            WriteLine("(4) Quit");
            Write("Enter your choice: ");

            choice = Convert.ToInt32(ReadLine());

            if (choice == 1)
            {
                // First to last
                for (int i = 0; i < numbers.Length; i++)
                {
                    Write(numbers[i] + " ");
                }
                WriteLine();
            }
            else if (choice == 2)
            {
                // Last to first
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    Write(numbers[i] + " ");
                }
                WriteLine();
            }
            else if (choice == 3)
            {
                Write("Enter a position (0 to 9): ");
                int pos = Convert.ToInt32(ReadLine());

                if (pos >= 0 && pos < numbers.Length)
                {
                    WriteLine("Value at position " + pos + " is " + numbers[pos]);
                }
                else
                {
                    WriteLine("Invalid position.");
                }
            }
            else if (choice != 4)
            {
                WriteLine("Invalid option.");
            }

        } while (choice != 4);

        WriteLine("Goodbye!");
    }
}
