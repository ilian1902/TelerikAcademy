namespace StringBuilder
{
    using System;
    using System.Text;
    using StringBuilder.Substring;
    

    class StringBuilderSubstringMain
    {
        // Implement an extension method Substring(int index, int length) for the class StringBuilder 
        // that returns new StringBuilder and has the same functionality as Substring in the class String.

        static void Main()
        {
            string text = "Pesho";
            Console.WriteLine(text.Substring(1, 3));// testing substring of string
            Console.WriteLine(text.Substring(2));
            StringBuilder sb = new StringBuilder();
            sb.Append("Gosho");
            sb.Append("Milena");
            Console.WriteLine(sb.SubString(1,2).ToString());
            Console.WriteLine(sb.SubString(1, 9).ToString());//testing substring of StringBuilder
            Console.WriteLine(sb.Substring(3));
            
            
        }
    }
}
