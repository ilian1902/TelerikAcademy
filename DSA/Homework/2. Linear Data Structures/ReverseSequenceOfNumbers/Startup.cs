namespace ReverseSequenceOfNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var array = GetArrayWithNumbers();
            var reversedNumbers = ReverseNumbers(array);
            PrintReversedNumbers(reversedNumbers);
        }

        public static string ReadNumbersFromConsole(bool invalidEnter)
        {
            Console.WriteLine(invalidEnter ?
                "Invalid sequence of integer numbers. Please try again!" :
                "Please enter a sequence of integer numbers separated by space and press enter!");

            var numbersFromConsole = Console.ReadLine();
            return numbersFromConsole;
        }

        private static void PrintReversedNumbers(IEnumerable<int> reversedNumbers)
        {
            Console.WriteLine();
            Console.WriteLine("Reversed numbers: ");
            Console.WriteLine(string.Join(", ", reversedNumbers));
        }

        private static IEnumerable<int> GetArrayWithNumbers()
        {
            var numbers = ReadNumbersFromConsole(false);
            var array = ReadSequenceOfNumbers.Startup.ConvertStringToIntegerList(numbers);
            return array;
        }

        private static IEnumerable<int> ReverseNumbers(IEnumerable<int> array)
        {
            var stack = new Stack<int>();
            foreach (var element in array)
            {
                stack.Push(element);
            }

            return stack.ToList();
        }
    }
}
