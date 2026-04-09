// Sum200.cs

using System;
using static System.Console;
using System.Globalization;

class Sum200
{
    static void Main()
    {
        int num; 
        int sum = 0;

        for (num = 1; num <= 200; num++)
        {        
            sum += num;

            if (num == 100)
            {
                WriteLine($"The sum at halfway point: {sum}");
            }
        }
        WriteLine($"The sum at the end: {sum}");

    }


}
