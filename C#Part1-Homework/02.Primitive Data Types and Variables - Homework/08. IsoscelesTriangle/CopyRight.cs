namespace IsoscelesTriangle
{
    using System;
    using System.Text;

    class CopyRight
    {
        // Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

        static void Main()
        {
            char unicode = '\u00A9';
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("   {0}\n  {0} {0}\n {0}   {0}\n{0} {0} {0} {0}", unicode);
        }
    }
}
