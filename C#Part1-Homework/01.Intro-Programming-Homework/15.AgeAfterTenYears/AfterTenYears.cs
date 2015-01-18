namespace AgeAfterTenYears
{
    using System;

    class AfterTenYears
    {
        /* Write a program to read your birthday from the console
           and print how old you are now and how old you will be after 10 years.
         */
        static void Main()
        {
            Console.WriteLine("Enter your birthday:");
           // Console.Write("Day = ");
            int day = int.Parse(Console.ReadLine());
            //Console.Write("Month = ");
            int month = int.Parse(Console.ReadLine());
           // Console.Write("Year = ");
            int year = int.Parse(Console.ReadLine());

            DateTime birthday = new DateTime(year, month, day);
            DateTime now = DateTime.Now;
            int monthNow = now.Month;
            int dayNow = now.Day;
            int yearNow = now.Year;
            int ageNow = now.Year - birthday.Year;
            int ageAFter = (now.Year - birthday.Year) + 10;

            if ((monthNow < birthday.Month) || (dayNow < birthday.Day))
            {
                ageNow = ageNow - 1;
                Console.WriteLine("Your age is " + ageNow);
            }
            else
            {
                Console.WriteLine("Your age is " + ageNow);
            }
            if ((monthNow < birthday.Month) || (dayNow < birthday.Day))
            {
                ageAFter = ageAFter - 1;
                Console.WriteLine("Your age after 10 years will " + ageAFter);
            }
            else
            {
                Console.WriteLine("Your age after 10 years will " + ageAFter);
            }
        }
    }
}
