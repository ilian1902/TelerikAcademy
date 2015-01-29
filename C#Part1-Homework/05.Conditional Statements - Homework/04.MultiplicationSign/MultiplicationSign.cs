namespace MultiplicationSign
{
    using System;

    class MultiplicationSign
    {
        /*Write a program that shows the sign (+, - or 0) of the product of three real numbers, 
          without calculating it.
          Use a sequence of if operators.
         */

        static void Main()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Result is 0");
            }
            else if (a > 0)
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        Console.WriteLine("Sign is +");
                    }
                    else
                    {
                        Console.WriteLine("Sign is -");
                    }
                }
                else
                {
                    if (c > 0)
                    {
                        Console.WriteLine("Sign is -");
                    }
                    else
                    {
                        Console.WriteLine("Sign is +");
                    }
                }
            }
            else
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        Console.WriteLine("Sign is -");
                    }
                    else
                    {
                        Console.WriteLine("Sign is +");
                    }
                }
                else
                {
                    if (c > 0)
                    {
                        Console.WriteLine("Sign is +");
                    }
                    else
                    {
                        Console.WriteLine("Sign is -");
                    }
                }
            }
        }
    }
}
