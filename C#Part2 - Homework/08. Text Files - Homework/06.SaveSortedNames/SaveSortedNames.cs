﻿namespace SaveSortedNames
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class SaveSortedNames
    {
        // Write a program that reads a text file containing a list of strings, 
        // sorts them and saves them to another text file
        // Example:
        // input.txt 	output.txt
        //  Ivan           George
        //  Peter           Ivan
        //  Maria           Maria
        //  George          Peter 	
                        

        static void Main()
        {
            
            using (StreamReader unsorted = new StreamReader(@"..\..\unsorted.txt"))
            {
                List<string> names = new List<string>();
                for (string currName = unsorted.ReadLine(); currName != null; currName = unsorted.ReadLine())
                {
                    names.Add(currName);
                }
                names.Sort();
                using (StreamWriter sorted = new StreamWriter(@"..\..\sorted.txt"))
                {
                    foreach (string name in names)
                    {
                        sorted.WriteLine(name);
                    }
                }
            }
            Console.WriteLine("Names are sorted!");
        }
    }
}
