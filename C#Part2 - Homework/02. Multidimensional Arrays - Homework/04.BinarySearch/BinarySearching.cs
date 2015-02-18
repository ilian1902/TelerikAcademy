namespace BinarySearch
{
    using System;

    class BinarySearching
    {
        /* Write a program, that reads from the console an array of N integers and an integer K, 
           sorts the array and using the method Array.BinSearch() 
           finds the largest number in the array which is ≤ K.
         */
        static void Main()
        {
            Console.Write("Enter size of array N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter K = ");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Index [{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            int maxValue = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < k)
                {
                    maxValue = arr[i];
                }
            }
            Array.BinarySearch(arr, maxValue);
            if (arr[0] > k)
            {
                Console.WriteLine("No number is lesser than the given max value.");
            }
            else
            {
                Console.WriteLine("Max number lesser than the given max value is: {0}", maxValue);
            }
        }
    }
}
