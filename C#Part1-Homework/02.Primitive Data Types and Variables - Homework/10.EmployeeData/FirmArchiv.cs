namespace EmployeeData
{
    using System;

    class FirmArchiv
    {
        /* A marketing company wants to keep record of its employees. 
           Each record would have the following characteristics:

            First name
            Last name
            Age (0...100)
            Gender (m or f)
            Personal ID number (e.g. 8306112507)
            Unique employee number (27560000…27569999)

           Declare the variables needed to keep the information for a single employee using appropriate 
           primitive data types. Use descriptive names. Print the data at the console.
         */
        static void Main()
        {
            string firstName;
            string familyName;
            byte age;
            char gender;
            uint idNumber;
            ulong uniqueNum;

            // For example!!!

            firstName = "Ilian";
            familyName = "Bratanov";
            age = 32;
            gender = 'M';
            idNumber = 2756000;
            uniqueNum = 8202190529;
            Console.WriteLine("The employee {0} {1}\nAGE {2}\nGenger {3}\nID {4}\nEGN {5}",
                firstName, familyName, age, gender, idNumber, uniqueNum);
        }
    }
}
