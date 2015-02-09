namespace CompareArrays
{
    using System;

    class CompareArrays
    {
        //Write a program that reads two integer arrays from the console and compares them element by element.

        static void Main()
        {
            //input
            Console.Write("Enter size of the first array: ");
            int firstNum = int.Parse(Console.ReadLine());
            int[] arrayOne = new int[firstNum];
            Console.Write("Enter size of the second array: ");
            int secondNum = int.Parse(Console.ReadLine());
            int[] arrayTwo = new int[secondNum];
            int count = 0;


            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.Write("First Array[{0}] = ", i);
                arrayOne[i] = int.Parse(Console.ReadLine());
                
            }

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                Console.Write("Second Array[{0}] = ", i);
                arrayTwo[i] = int.Parse(Console.ReadLine());
            }

            if (arrayOne.Length == arrayTwo.Length)
            {
                for (int i = 0; i < arrayOne.Length; i++)
                {
                    if (arrayOne[i]==arrayTwo[i])
                    {
                        count++;
                    }
                }
            }
            
            Console.WriteLine("Equal = {0}", count);
        }
    }
}
