namespace DefiningClassesPartTwoProblem567
{
    using System;

    public class GenericClassMain
    {
        static void Main()
        {
            GenericList<int> testList = new GenericList<int>();

            for (int i = 5; i <= 20; i++)
            {
                testList.Add(i); //Testing method Add
            }

            for (int i = 0; i < testList.Count - 1; i++)
            {
                Console.Write(testList[i]);
            }
            Console.WriteLine();
            Console.Write("Enter search element of GenericList = ");
            int searchTofIndex = int.Parse(Console.ReadLine());
            var resultIndex = testList.IndexOf(searchTofIndex);// testing method indexOf
            Console.WriteLine("Search number is {0} = Index [{1}]", searchTofIndex, resultIndex);

            Console.Write("Enter the number to be inserted = ");

            int numberOfInsert = int.Parse(Console.ReadLine());

            Console.Write("Enter the index to insert = ");

            int indexUser = int.Parse(Console.ReadLine());

            testList.InsertAt(numberOfInsert, indexUser);// testing method InsertAt

            Console.WriteLine("TestList[{0}] = {1}", indexUser, testList[indexUser]);

            Console.WriteLine(testList); //ToString, Min and Max
            Console.WriteLine("Min: {0}", testList.Min());
            Console.WriteLine("Max: {0}", testList.Max());

            testList.ClearList();//test method clear
            for (int i = 0; i < testList.Capacity; i++)
            {
                Console.Write(testList[i]);
            }
            Console.WriteLine(" Test clear");
        }
    }
}
