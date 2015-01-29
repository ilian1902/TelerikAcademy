namespace PlayWithIntDoubleAndString
{
    using System;

    class PlayWithIntDoubleAndString
    {
        /* Write a program that, depending on the user’s choice, inputs an int, double or string variable.
           If the variable is int or double, the program increases it by one.
           If the variable is a string, the program appends * at the end.
           Print the result at the console. Use switch statement.
         */
    
        static void Main()
        {
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int userChois = int.Parse(Console.ReadLine());
            switch (userChois)
            {
                case 1: Console.WriteLine("Please enter a integer:");
                    int userInt = int.Parse(Console.ReadLine());
                    userInt = userInt + 1;
                    Console.WriteLine(userInt);
                    break;
                case 2: Console.WriteLine("Please enter a double:");
                    double userDouble = double.Parse(Console.ReadLine());
                    userDouble = userDouble + 1;
                    Console.WriteLine(userDouble);
                    break;
                case 3: Console.WriteLine("Please enter a string:");
                    string userString = Console.ReadLine();
                    userString = userString + "*";
                    Console.WriteLine(userString);
                    break;
                default: Console.WriteLine("No correct chois:");
                    break;
                    
            }
        }
    }
}
