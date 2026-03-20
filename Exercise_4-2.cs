// Twitter.cs

using System;
using static System.Console;
using System.Globalization;

class Twitter
{
	static void Main()
	{
		string message;

		Write("Enter your message >> ");
		message = ReadLine();

		if(message.Length > 140)
		{
			WriteLine("The message is too long.");
		}
		else
		{
			WriteLine("The message is okay.");
		}
	}
}
