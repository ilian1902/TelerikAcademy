namespace CombinationNK
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            //// Write a recursive program for generating and printing all the combinations with duplicatesof k elements from n-element set. Example:
            //// n = 3, k = 2 → (1 1), (1 2), (1 3), (2 2), (2 3), (3 3)

            Console.Write("N = ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            var k = int.Parse(Console.ReadLine());

            const int IndexOfArray = 0;
            const int Start = 1;

            int[] arr = new int[k];
            GenerateCombination(arr, IndexOfArray, Start, n);
        }

        private static void GenerateCombination(int[] arr, int index, int start, int end)
        {
            if (index == arr.Length)
            {
                Console.WriteLine("(" + string.Join(",", arr) + ")");
                return;
            }

            for (int i = start; i <= end; i++)
            {
                arr[index] = i;
                GenerateCombination(arr, index + 1, i, end);
            }
        }
    }
}
