// Perfect.cs

using System;
using static System.Console;
using System.Globalization;

class Perfect
{
    static void Main()
    {
        int num, div, sum;
        for (num = 1; num <= 10000; num++) {
            sum = 0;
            for (div = 1; div < num; div++) {
                // modulus = %
                if (num % div == 0) {
                    sum += div;
                    if (sum == num) {
                        WriteLine(num);
                    }   
                }

            }
        }
    ReadKey();    
    }
}
