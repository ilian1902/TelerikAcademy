namespace ReadSequenceOfNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var numbersAsString = GetNumbersFromConsole(false);
            PrintNumbers(numbersAsString);
        }

        public static int[] ConvertStringToIntegerList(string numbersAsString)
        {
            var tokens = numbersAsString.Split(' ');
            int[] array;

            try
            {
                array = Array.ConvertAll(tokens, int.Parse);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format! Please try again!");
                Console.Clear();
                var numbersFromConsole = GetNumbersFromConsole(true);
                array = ConvertStringToIntegerList(numbersFromConsole);
            }

            return array;
        }

        public static IEnumerable<int> ConvertIntegersArrayToList(int[] array)
        {
            var list = Enumerable.OfType<int>(array)
                .ToList();

            return list;
        }

        public static string GetNumbersFromConsole(bool invalidEnter)
        {
            Console.WriteLine(invalidEnter ?
                "Invalid sequence of positive integer numbers. Please try again!" :
                "Please enter a sequence of integer numbers separated by space and press enter!");

            var numbersFromConsole = Console.ReadLine();
            return numbersFromConsole;
        }

        private static void PrintNumbers(string numbersAsString)
        {
            try
            {
                var array = ConvertStringToIntegerList(numbersAsString);
                var list = ConvertIntegersArrayToList(array);

                Console.WriteLine();
                Console.WriteLine("Numbers are successfully readed and added to list!");

                Console.WriteLine(string.Join(", ", list));
            }
            catch (Exception)
            {
                Console.WriteLine("Numbers are UNsuccessfully readed and added to list!");
            }
        }
    }
}
