namespace ParseTags
{
    using System;

    class ParseTags
    {
        /* You are given a text. Write a program that changes the text in all regions surrounded by the tags 
           <upcase> and </upcase> to upper-case.
           The tags cannot be nested.
           Example: We are living in a <upcase>yellow submarine</upcase>. We don't have 
                    <upcase>anything</upcase> else.

           The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
         */

        static void Main()
        {
            Console.WriteLine("Enter text with <upcase> and </upcase>");
            string userText = Console.ReadLine();
           
            Console.WriteLine(UpperCase(userText));
        }

        public static string UpperCase(string text)
        {
            while (text.IndexOf("<upcase>") != -1)
            {
                int PosStart = text.IndexOf("<upcase>");
                int PosEnd = text.IndexOf("</upcase>");
                string temp = text.Substring(PosStart + "<upcase>".Length, PosEnd - PosStart - "<upcase>".Length);
                text = text.Replace("<upcase>" + temp + "</upcase>", temp.ToUpper());
            }
            return text;
        }
    }
}
