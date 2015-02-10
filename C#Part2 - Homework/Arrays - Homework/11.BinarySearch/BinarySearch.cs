namespace BinarySearch
{
    using System;

    class BinarySearch
    {
        // Write a program that finds the index of given element 
        // in a sorted array of integers by using the Binary search algorithm.

        static void Main()
        {
            Console.Write("Enter size of array = ");
            int size = int.Parse(Console.ReadLine());
            int[] userArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Index [{0}]", i);
                userArray[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter number which is sought = ");
            int searchNum = int.Parse(Console.ReadLine());

            Array.Sort(userArray);

            int searchIndex = BinarySearch(userArray, searchNum, 0, userArray.Length);
            Console.WriteLine(searchIndex);
        }
        private static int BinarySearch(int[] someArray, int number, int min, int max)
        {
            if (max < min)
            {
                return -1;
            }
            else
            {
                int middleIndex = (min + max) / 2;
                if (someArray[middleIndex] > number)
                {
                    return BinarySearch(someArray, number, min, middleIndex - 1);
                }
                else if (someArray[middleIndex] < number)
                {
                    return BinarySearch(someArray, number, middleIndex + 1, max);
                }
                else
                {
                    return middleIndex;
                }
            }
        }
    }
}