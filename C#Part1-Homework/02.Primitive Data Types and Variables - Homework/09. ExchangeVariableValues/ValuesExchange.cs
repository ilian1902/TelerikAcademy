namespace ExchangeVariableValues
{
    using System;

    class ValuesExchange
    {
        /* Declare two integer variables a and b and assign them with 5 and 10 and after that exchange 
           their values by using some programming logic.
           Print the variable values before and after the exchange.
         */

        static void Main()
        {
            int firstVar = 5;
            int secondVar = 10;
            Console.WriteLine("Before the change {0} {1}", firstVar, secondVar);
            secondVar = secondVar - firstVar;
            firstVar = secondVar + firstVar;
            Console.WriteLine("After change      {0} {1}", firstVar, secondVar);
        }
    }
}
