using System;
using System.Globalization;

public class Trial
{
    private static void Main()
    {
		string[] input = Console.ReadLine().Split(
		   new char[] { ' ', '\t', '\n', '\r' },
		   StringSplitOptions.RemoveEmptyEntries);

		Console.WriteLine(Convert.ToInt32(input[0]) * (Convert.ToInt32(input[1])+1));

    }
}