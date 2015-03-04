namespace ConcatenateTextFiles
{
    using System;
    using System.IO;

    class ConcatenateTextFiles
    {
        // Write a program that concatenates two text files into another text file.

        static void Main()
        {
            using (StreamWriter write = new StreamWriter(@"..\..\concatenatedTest.txt", true))
            {
                using (StreamReader firstReader = new StreamReader(@"..\..\TestOne.txt"))
                {
                    string line = firstReader.ReadLine();
                    while (line != null)
                    {
                        write.WriteLine(line);
                        line = firstReader.ReadLine();
                    }
                }
                using (StreamReader secondReader = new StreamReader(@"..\..\TestTwo.txt"))
                {
                    string line = secondReader.ReadLine();
                    while (line != null)
                    {
                        write.WriteLine(line);
                        line = secondReader.ReadLine();
                    }
                }
            }
            Console.WriteLine("Concatenation is done.");
            
            using(StreamReader readConcatenation = new StreamReader(@"..\..\concatenatedTest.txt"))
            {
                Console.WriteLine(readConcatenation.ReadToEnd());
            }
        }
    }
}
