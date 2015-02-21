namespace SortingArray
{
    using System;

    class SortingArray
    {
        /* Write a method that return the maximal element in a portion of array of integers starting at given index.
           Using it write another method that sorts an array in ascending / descending order.
         */

        static void Main()
        {
            Console.Write("Enter size of array = ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Index [{0}] = ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter start index = ");
            int startIndex = int.Parse(Console.ReadLine());
            Console.Write("Enter end index = ");
            int endIndex = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Max element in interval [{0}, {1}] -> {2}", startIndex, endIndex, FindMaxElement(numbers, startIndex, endIndex));
            Console.WriteLine("Numbers sort {0}", string.Join(" ", SortArray(numbers)));

        }


        static int FindMaxElement(int[] nums, int start, int end, int swapIndex = 0)
        {

            int maxIndex = start;
            for (int i = start; i <= end; i++)
            {
                if (nums[maxIndex] < nums[i])
                {
                    maxIndex = i;
                }
            }
            int temp = nums[swapIndex];
            nums[swapIndex] = nums[maxIndex];
            nums[maxIndex] = temp;
            return nums[swapIndex];
        }


        static int[] SortArray(int[] nums)
        {
            int size = nums.Length;
            int[] sort = new int[size];
            for (int i = size - 1; i >= 0; i--)
            {
                sort[i] = FindMaxElement(nums, 0, i, i);
            }
            return sort;
        }
    }
}
