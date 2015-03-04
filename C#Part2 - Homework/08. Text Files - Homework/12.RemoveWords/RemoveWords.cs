namespace RemoveWords
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class RemoveWords
    {
        // Write a program that removes from a text file all words listed in given another text file.
        // Handle all possible exceptions in your methods.

        static void Main()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"..\..\output.txt"))
                {
                    using (StreamReader sr = new StreamReader(@"..\..\test.txt"))
                    {
                        string line;
                        string regex = @"\b(" + String.Join("|", File.ReadAllLines(@"..\..\words.txt")) + @")\b";
                        while ((line = sr.ReadLine()) != null)
                        {
                            line = line.ToLower();
                            line = Regex.Replace(line, regex, string.Empty);
                            sw.WriteLine(line);
                        }
                    }
                }
            }
            catch (FieldAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
