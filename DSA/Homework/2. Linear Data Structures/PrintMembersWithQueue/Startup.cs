namespace PrintMembersWithQueue
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var number = GetUserInputNumber(false);
            var calculatedNumbers = GetMembersWithQueue(number);

            PrintNumbers(calculatedNumbers);
        }

        private static List<int> GetMembersWithQueue(int number)
        {
            var queue = new Queue<int>();
            queue.Enqueue(number);

            var numbers = new List<int>();
            numbers.Add(number);

            for (int i = 0, counter = 0; i < 49; i++, counter++)
            {
                int currentSum;
                switch (counter)
                {
                    case 0:
                        currentSum = queue.Peek() + 1;
                        queue.Enqueue(currentSum);
                        numbers.Add(currentSum);
                        break;
                    case 1:
                        currentSum = (2 * queue.Peek()) + 1;
                        queue.Enqueue(currentSum);
                        numbers.Add(currentSum);
                        break;
                    case 2:
                        currentSum = queue.Peek() + 2;
                        queue.Enqueue(currentSum);
                        queue.Dequeue();
                        numbers.Add(currentSum);

                        counter = -1;
                        break;
                }
            }

            return numbers;
        }

        private static void PrintNumbers(List<int> numbers)
        {
            for (var i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine("{0}. => value: {1}", i + 1, numbers[i]);
            }
        }

        private static int GetUserInputNumber(bool invalidNumber)
        {
            Console.WriteLine(invalidNumber ? "Invalid number! Please enter valid integer number:" : "Please enter valid integer number:");
            var numberAsString = Console.ReadLine();

            int number;
            try
            {
                if (!string.IsNullOrEmpty(numberAsString))
                {
                    number = int.Parse(numberAsString);
                }
                else
                {
                    throw new ArgumentNullException("Number is null!", new ArgumentNullException());
                }
            }
            catch (ArgumentNullException)
            {
                Console.Clear();
                number = GetUserInputNumber(true);
            }
            catch (FormatException)
            {
                Console.Clear();
                number = GetUserInputNumber(true);
            }
            catch (ArgumentException)
            {
                Console.Clear();
                number = GetUserInputNumber(true);
            }

            Console.WriteLine();
            return number;
        }
    }
}
