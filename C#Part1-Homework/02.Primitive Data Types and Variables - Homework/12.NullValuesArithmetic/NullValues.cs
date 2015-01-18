namespace NullValuesArithmetic
{
    using System;

    class NullValues
    {
        /* Create a program that assigns null values to an integer and to a double variable.
           Try to print these variables at the console.
           Try to add some number or the null literal to these variables and print the result.
         */

        static void Main()
        {
            int? nullVal = null;
            double? nullPoint = null;
            Console.WriteLine("{0} \n{1}", nullVal, nullPoint);
            nullVal = 12;
            nullPoint = 3.14;
            Console.WriteLine("{0} \n{1}", nullVal, nullPoint);
        }
    }
}
