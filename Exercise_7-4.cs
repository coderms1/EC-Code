// Exercise: 7-4: FortuneTeller.cs

using System;
using static System.Console;
using System.Globalization;

class FortuneTeller
{
    static void Main()
    {
        string[] phrases =
        {
            "I see a tall, dark stranger in your future.", // #0
            "Big moves are coming soon.", // #1
            "Your grind is about to pay off.", // #2
            "A random opportunity is coming.", // #3
            "Trust your instincts this week.", // #4
            "A new connection will help you.", // #5
        };

        Random random = new Random();

        int fortune_1 = random.Next(phrases.Length);
        int fortune_2 = random.Next(phrases.Length);

        while (fortune_1 == fortune_2)
        {
            fortune_2 = random.Next(phrases.Length);
        }
        ShowFortune(phrases[fortune_1], phrases[fortune_2]);
    }

    static void ShowFortune(string f1, string f2)
    {
        WriteLine(f1);
        WriteLine(f2);
    }
}
