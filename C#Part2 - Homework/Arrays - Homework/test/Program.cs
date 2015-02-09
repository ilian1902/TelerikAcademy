using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System;
//Problem 5. Maximal increasing sequence
//Write a program that finds the maximal increasing sequence in an array.
//Example:
//input result
//3, 2, 3, 4, 2, 2, 4 2, 3, 4
class Sequence
{
    static void Main()
    {
        
        Console.WriteLine("N:");
        int n = int.Parse(Console.ReadLine());
       
        int longest = 1;
        int currentSequence = 1;
        
        //2 int[] elements = new int[n];
        string sequence = "";
        //1 elements[0] = int.Parse(Console.ReadLine()); 
        string temp = elements[0] + ","; 
        for (int i = 1; i < n; i++)
        {
            elements[i] = int.Parse(Console.ReadLine()); 
            if (elements[i - 1] < elements[i])
            {
                currentSequence++; 
                temp += elements[i] + ","; 
                if (currentSequence > longest) 
                {
                    longest = currentSequence;
                    sequence = temp;
                }
            }
            else 
            {
                currentSequence = 1;
                temp = elements[i] + ",";
            }
        }
        // remove trailing ", "
        Console.WriteLine(sequence.TrimEnd(','));
    }
}
