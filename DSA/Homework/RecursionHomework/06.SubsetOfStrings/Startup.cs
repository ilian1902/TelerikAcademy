namespace SubsetOfStrings
{
    using System;

    public class Startup
    {
        private const int N = 2;
        private static readonly string[] Set = { "test", "rock", "fun" };
        private static int[] arr;
        
        public static void Main()
        {
            ////  Write a program for generating and printing all subsets of k strings from given set of strings.
            ////  Example: s = { test, rock, fun}, k = 2 → (test rock), (test fun), (rock fun)

            arr = new int[N];

            GenerateCombinations(0, 0, 2);
        }

        private static void GenerateCombinations(int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                PrintCombinations();
                return;
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    GenerateCombinations(index + 1, i + 1, end);
                }
            }
        }

        private static void PrintCombinations()
        {
            Console.Write("( ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(Set[arr[i]] + " ");
            }

            Console.WriteLine(")");
        }
    }
}