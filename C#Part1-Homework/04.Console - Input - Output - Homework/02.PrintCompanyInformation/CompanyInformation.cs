namespace PrintCompanyInformation
{
    using System;

    class CompanyInformation
    {
        /* A company has name, address, phone number, fax number, web site and manager. 
           The manager has first name, last name, age and a phone number.
           Write a program that reads the information about a company and its manager and prints it back on the console.
         */

        static void Main()
        {
            Console.WriteLine("Enter company name");
            string nameCompany = Console.ReadLine();
            Console.WriteLine("Enter address of company");
            string addresCompany = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            int phoneNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter fax number");
            int faxNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter web side");
            string webSide = Console.ReadLine();
            Console.WriteLine("Enter first name of Manager");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter last name of Manager");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter age of Manager");
            byte ageManager = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter phone of Manager");
            int phoneManager = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(nameCompany);
            Console.WriteLine("Address:" + addresCompany);
            Console.WriteLine("Tel:" + phoneNum);
            Console.WriteLine("Fax:" + faxNum);
            Console.WriteLine("Web side: http://" + webSide);
            Console.WriteLine("Manager: {0}{1} (Age: {2}, Tel: {3})",firstName, lastName, ageManager, phoneManager);
        }
    }
}
