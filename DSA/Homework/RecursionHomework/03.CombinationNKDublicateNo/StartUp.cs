namespace CombinationNKDublicateNo
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            //// Modify the previous program to skip duplicates:
            //// n = 4, k = 2 → (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)

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
                GenerateCombination(arr, index + 1, i + 1, end);
            }
        }
    }
}
