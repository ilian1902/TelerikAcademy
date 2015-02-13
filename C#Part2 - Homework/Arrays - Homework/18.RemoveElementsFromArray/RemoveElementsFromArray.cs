namespace RemoveElementsFromArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RemoveElementsFromArray
    {
        /* Write a program that reads an array of integers and removes from it a minimal 
           number of elements in such a way that the remaining array is sorted in increasing order.
           Print the remaining sorted array.
           Example:
            input 	                        result
            6, 1, 4, 3, 0, 3, 6, 4, 5 	    1, 3, 3, 4, 5
         */

        static void Main()
        {
            Console.Write("Enter size of array N=");
            int n = int.Parse(Console.ReadLine());
            List<int> array = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("element[{0}]=", i);
                array.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = 0; i < array.Count - 1; i++)
            {
                if (array[i] > array[i + 1] || array[i] < array[0])
                {
                    array.Remove(array[i]);
                }
            }
            for (int i = 0; i < array.Count; i++)
            {
                if (i < array.Count - 1)
                {
                    Console.Write(array[i] + " ");
                }
                else
                {
                    Console.WriteLine(array[i] + " ");
                }
            }
        }
    }
}
