namespace DefiningClassesPartTwoProblem11
{
    using System;

    [Version("v. 2.10")]

    public class VersionAttributeMain
    {
        static void Main()
        {
            Type type = typeof(VersionAttributeMain);
            object[] attr = type.GetCustomAttributes(false);
            foreach (VersionAttribute item in attr)
            {
                Console.WriteLine(item.Version);
            }
        }
    }
}
