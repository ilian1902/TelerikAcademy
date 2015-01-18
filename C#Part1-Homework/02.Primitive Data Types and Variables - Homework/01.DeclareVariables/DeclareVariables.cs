namespace DeclareVariables
{
    using System;

    class DeclareVariables
    {
        /*Declare five variables choosing for each of them the most appropriate of the types
          byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values:
          52130, -115, 4825932, 97, -10000.
          Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
         */

        static void Main()
        {
            byte firstNum = 97;
            sbyte secondNum = -115;
            short thirdNum = -10000;
            ushort fourthNum = 52130;
            int fifthNum = 4825932;

            Console.WriteLine(" {0}\n {1}\n {2}\n {3}\n {4}",firstNum, secondNum, thirdNum, fourthNum, fifthNum);

        }
    }
}
