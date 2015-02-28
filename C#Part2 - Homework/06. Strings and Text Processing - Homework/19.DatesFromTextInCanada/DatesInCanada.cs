namespace DatesFromTextInCanada
{
    using System;
    using System.Globalization;
    using System.Threading;

    class DatesInCanada
    {
        // Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
        // Display them in the standard date format for Canada.

        static void Main()
        {
            string input = "I was born at 19.02.1982 . In 1999 I felt down on the street from my first car. At 5.01.2015 I signed up to learn programming Telerik Academy.";
            string[] words = input.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                try
                {
                    DateTime date = DateTime.ParseExact(words[i], "d.M.yyyy",
                    CultureInfo.InvariantCulture);
                    Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-CA");
                    Console.WriteLine("Canada (english): {0}", date.Date.ToLongDateString());
                }
                catch (FormatException)
                {
                }
            }
        }
    }
}
