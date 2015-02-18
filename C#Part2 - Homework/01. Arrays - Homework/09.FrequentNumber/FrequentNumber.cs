namespace FrequentNumber
{
    using System;

    class FrequentNumber
    {
        /* Write a program that finds the most frequent number in an array.
          
         Example:
                  input 	                              result
         4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3      	4 (5 times)
         */

        static void Main()
        {
            Console.Write("Enter size of array = ");
            int size = int.Parse(Console.ReadLine());
            int[] arrayNums = new int[size];

            for (int i = 0; i < size; i++)
            {
                arrayNums[i] = int.Parse(Console.ReadLine());
            }

            int count = 0;
            int currentNum = arrayNums[0];
            int nextNum;
            int realNum = 0;
            int bestCount = 0;


            for (int i = 0; i < size; i++)
            {
                currentNum = arrayNums[i];
                for (int j = 1; j < size; j++)
                {
                    nextNum = arrayNums[j];
                    
                    if (currentNum == nextNum)
                    {
                        count++;
                        realNum = currentNum;
                        
                    }
                }
                if (count > bestCount)
                {
                    bestCount = count;
                }
                count = 0;
            }
            Console.WriteLine("{0}({1}Times)", realNum, bestCount);
            
        }
    }
}
