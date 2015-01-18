namespace GravitationOnTheMoon
{
    using System;

    class Moon
    {
        /* The gravitational field of the Moon is approximately 17% of that on the Earth.
           Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
         */

        static void Main()
        {
            Console.WriteLine("Enter your weight:");
            float weight = float.Parse(Console.ReadLine());
            float moon = (weight * 17) / 100;
            Console.WriteLine("Your weight in the moon is {0}", moon);
        }
    }
}
