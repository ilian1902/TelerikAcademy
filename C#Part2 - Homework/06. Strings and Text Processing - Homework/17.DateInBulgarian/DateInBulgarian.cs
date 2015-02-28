namespace DateInBulgarian
{
    using System;
    using System.Globalization;
    using System.Text;

    class DateInBulgarian
    {
        /* Write a program that reads a date and time given in the format: day.month.year 
           hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) 
           along with the day of week in Bulgarian.
         */

        static void Main()
        {
            Console.Write("Enter date in format [dd.MM.yyyy hh:mm:ss] = ");
            string input = Console.ReadLine();
            string[] dateUser = input.Split(new char[] { ' ', '.', ':', '/' });
            DateTime date;
            try
            {
                date = new DateTime(
                int.Parse(dateUser[2]), // year
                int.Parse(dateUser[1]), // month
                int.Parse(dateUser[0]), // day
                int.Parse(dateUser[3]), // hour
                int.Parse(dateUser[4]), // minute
                int.Parse(dateUser[5])); // second
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Invalid date!");
                return;
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid date!");
                return;
            }
            date = date.AddHours(6).AddMinutes(30);
            var culture = new CultureInfo("bg-BG");
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine(date.ToString(culture));
            Console.WriteLine(culture.DateTimeFormat.GetDayName(date.DayOfWeek));
        }
    }
}
