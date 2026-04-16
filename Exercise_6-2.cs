// TestScoreList.cs

using System;
using static System.Console;
using static System.Array;
using static System.Math;
using System.Globalization;


class TestScoreList
{
    static void Main()
    {
        int[] scoreList = new int[8];
        int num;
        double total = 0;
        double avg;
        for (num = 0; num < scoreList.Length; num++)
        {   
            Write("Enter test score for number {0} >> ", num + 1);
            scoreList[num] = Convert.ToInt32(ReadLine());
            total += scoreList[num];
        }
        avg = total / scoreList.Length;
        for (num = 0; num < scoreList.Length; num++)
        {
            WriteLine("Test # {0}: {1, 5} From average: {2, 5}", 
            num, scoreList[num], scoreList[num] - avg);
        }
        WriteLine("Total: {0, 5}", total);
        WriteLine("Average: {0, 5}", avg);
    }


}
