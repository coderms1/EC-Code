// DisplayMultiplicationTable.cs

using System;
using static System.Console;

class DisplayMultiplicationTable
{
    static void Main()
    {
        int row, col;

        Write("{0,3}", "");
        for (col = 1; col <= 10; col++)
        {
            Write("{0,4}", col);
        }
        WriteLine();

        WriteLine(new string('-', 43));

        for (row = 1; row <= 10; row++)
        {
            Write("{0,3}", row);

            for (col = 1; col <= 10; col++)
            {
                Write("{0,4}", row * col);
            }

            WriteLine();
        }

        // 👇 RIGHT HERE
        ReadKey();
    }
}
