namespace ParseURL
{
    using System;

    class ParseURL
    {
        /* Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] 
           and extracts from it the [protocol], [server] and [resource] elements.
          Example:
            URL 	                                                Information
        http://telerikacademy.com/Courses/Courses/Details/212   	[protocol] = http
                                                                    [server] = telerikacademy.com
                                                                    [resource] = /Courses/Courses/Details/212
         */

        static void Main()
        {
            Console.WriteLine("Enter URL: Forexample http://telerikacademy.com/Courses/Courses/Details/212");
            string input = Console.ReadLine();
           
            int serverIndex = input.IndexOf("://");
            int resIndex = input.Substring(serverIndex + 3).IndexOf("/") + serverIndex + 3;
            Console.WriteLine("[protocol] = " + input.Substring(0, serverIndex));
            Console.WriteLine("[server] = " + input.Substring(serverIndex + 3, resIndex - serverIndex - 3));
            Console.WriteLine("[resource] = " + input.Substring(resIndex));
            
        }
    }
}
