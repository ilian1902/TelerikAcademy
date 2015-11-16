namespace SumOfDifferences
{
    using System;
    using System.Collections.Generic;
    
    internal class SumOfDifferencesExam
    {
        internal static long MaxMethod(int start, int end)
        {
            long maxNum = long.MinValue;
            if (start > end)
            {
                maxNum = start;
            }
            else if (start == end)
            {
                maxNum = start;
            }
            else
            {
                maxNum = end;
            }

            return maxNum;
        }

        internal static long MinMethod(int start, int end)
        {
            long minNum = long.MaxValue;
            if (start > end)
            {
                minNum = end;
            }
            else if (start == end)
            {
                minNum = start;
            }
            else
            {
                minNum = start;
            }

            return minNum;
        }

        private static void Main()
        {
            string inputNum = Console.ReadLine();
            string[] numbs = inputNum.Split(' ');
            var numbers = new List<int>();

            for (int i = 0; i < numbs.Length; i++)
            {
                numbers.Add(int.Parse(numbs[i]));
            }

            int oddJump = 1;
            int evenLump = 2;
            int position = 1;
            int currentPosition = 1;
            long result = 0;

            int steps = 1;
            while (true)
            {
                steps++;
                var start = numbers[currentPosition];
                var end = numbers[currentPosition - 1];
                var maxNumb = MaxMethod(start, end); // Math.Max(numbers[currentPosition], numbers[currentPosition - 1]);
                var minNumb = MinMethod(start, end); // Math.Min(numbers[currentPosition], numbers[currentPosition - 1]);
                var diference = maxNumb - minNumb;
                var jump = diference % 2;
                if (diference % 2 != 0)
                {
                    position = currentPosition + oddJump;
                    currentPosition = position;
                    result += diference;
                    if (currentPosition >= numbers.Count)
                    {
                        Console.WriteLine(result);
                        break;
                    }
                }
                else
                {
                    position = currentPosition + evenLump;
                    currentPosition = position;
                    if (position >= numbers.Count)
                    {
                        Console.WriteLine(result);
                        break;
                    }
                }
            }
        }
    }
}
