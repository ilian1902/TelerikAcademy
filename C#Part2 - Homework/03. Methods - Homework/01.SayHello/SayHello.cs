namespace SayHello
{
    using System;

    class SayHello
    {
        // Write a method that asks the user for his name and prints “Hello, <name>”
        // Write a program to test this method.
        // Example:
        //      input 	output
        //      Peter 	Hello, Peter!

        static void Main()
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            
            Hello(name);
        }
        static void Hello(string str)
        {
            Console.WriteLine("Hello, {0}!", str);
        }
    }
}
