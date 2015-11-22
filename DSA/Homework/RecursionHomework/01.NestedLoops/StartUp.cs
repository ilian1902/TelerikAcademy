namespace NestedLoops
{
    using System;

    public class StartUp
    {
        private static int[] arr;

        public static void Main()
        {
            //// 1. Write a recursive program that simulates the execution of n nested loopsfrom 1 to n.

            Console.Write("Enter one number: ");
            int n = int.Parse(Console.ReadLine());
            arr = new int[n];
            PrintNumber(0);
        }

        private static void PrintNumber(int n)
        {
            if (n == arr.Length)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[n] = i + 1;
                PrintNumber(n + 1);
            }
        }
    }
}
