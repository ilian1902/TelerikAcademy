namespace MergeSort
{
    using System;

    class MergeSortByInt
    {
        // Write a program that sorts an array of integers using the Merge sort algorithm.

        static void Main()
        {
            Console.Write("Size array = ");
            int size = int.Parse(Console.ReadLine());
            int [] userArray = new int[size];
            int[] temp = new int[size];

            for (int i = 0; i < size; i++)
            {
                userArray[i] = int.Parse(Console.ReadLine());
            }

            MergeSort(userArray, temp, 0, userArray.Length-1);
            for (int i = 0; i < userArray.Length; i++)
            {
                if (i<userArray.Length-1)
                {
                    Console.Write(userArray[i] + " ");
                }
                else
                {
                    Console.WriteLine(userArray[i] + " ");
                }
            }

        }
        static void MergeSort(int[] elements, int[] temp, int start, int end)
        {
            if (start >= end)
            {
                return;
            }
            int middle = start + (end - start) / 2;
            MergeSort(elements, temp, start, middle);
            MergeSort(elements, temp, middle + 1, end);
            int i = start;
            int l = start, m = middle + 1;
            while (l <= middle && m <= end)
            {
                temp[i++] = (elements[l] > elements[m]) ? elements[m++] : elements[l++];
            }
            while (l <= middle)
            {
                temp[i++] = elements[l++];
            }
            while (m <= end)
            {
                temp[i++] = elements[m++];
            }
            for (int j = start; j <= end; j++)
            {
                elements[j] = temp[j];
            }
        }
    }
}
