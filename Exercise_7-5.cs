// Exercise: 7-5: FineForOverdueBooks.cs

using System;
using static System.Console;
using System.Globalization;

class FineForOverdueBooks
{
    static void Main()
    {
        int books;
        int days;
        Write("Enter number of books checked out >> ");
        books = Convert.ToInt32(ReadLine());
        Write("Enter number of overdue days >> ");
        days = Convert.ToInt32(ReadLine());
        DisplayFine(books, days);
    }

    public static void DisplayFine(int books, int days) {
        double fine;
        if (days <= 7) {
            fine = books * days * 0.10;
        }
        else {
            fine = (books * 7 * 0.10) + (books * (days - 7) * 0.20);
        }
        WriteLine("The fine for {0} book(s) for {1} day(s) is {2}", 
            books, 
            days, 
            fine.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }
}
