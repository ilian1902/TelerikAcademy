namespace BankAccountData
{
    using System;

    class Bank
    {
        /* A bank account has a holder name (first name, middle name and last name), 
           available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
           Declare the variables needed to keep the information for a single bank account using the appropriate 
           data types and descriptive names.
         */

        static void Main()
        {
            string firstName;
            string middleName;
            string lastName;
            decimal balance;
            string bankName;
            string iban;
            string bicCode;
            long cardNum1;
            long cardNum2;
            long cardNum3;

            //For example!!!
            firstName = "Ilian";
            middleName = "Bratanov";
            lastName = "Bratanov";
            string fullName = firstName + " " + middleName + " " + lastName;
            Console.WriteLine(fullName);
            balance = 150000.12564m;
            bankName = "FI Bank";
            iban = "BG98076FI8767899";
            bicCode = "BGFIBA542";
            cardNum1 = 4554213215456548;
            cardNum2 = 5487456265481236;
            cardNum3 = 2569874565986532;
            Console.WriteLine("{0}$\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}", balance, bankName,
                iban, bicCode, cardNum1, cardNum2, cardNum3);
        }
    }
}
