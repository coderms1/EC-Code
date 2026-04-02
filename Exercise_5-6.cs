// DisplayMultiplicationTable.cs

using System;
using static System.Console;

class DisplayMultiplicationTable
{
    static void Main()
    {
        int row, column;

        Write("{0,3}", "");
        for (column = 1; column <= 10; column++)
        {
            Write("{0,4}", column);
        }
        WriteLine();

        WriteLine("new string('-', 43));

        for (row = 1; row <= 10; row++)
        {
            Write("{0,3}", row);

            for (column = 1; column <= 10; column++)
            {
                Write("{0,4}", row * col);
            }

            WriteLine();
        }

        ReadKey();
    }
}
