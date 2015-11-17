namespace ImplementLinkedList
{
    using System;

    using Interfaces;
    using DataStructures;

    public class Startup
    {
        public static void Main()
        {
            var linkedList = CreateSampleLinkedLists();

            SamplePrintOfItemsValues(linkedList);
        }

        private static ILinkedList<int> CreateSampleLinkedLists()
        {
            IListItem<int> firstListItem = new ListItem<int>();
            IListItem<int> secondListItem = new ListItem<int>();
            IListItem<int> lastListItem = new ListItem<int>();

            ILinkedList<int> linkedList = new LinkedList<int>()
            {
                FirstItem = firstListItem
            };

            firstListItem.Value = 1;
            firstListItem.NextItem = secondListItem;

            secondListItem.Value = 2;
            secondListItem.NextItem = lastListItem;

            lastListItem.Value = 3;
            lastListItem.NextItem = null;

            return linkedList;
        }

        private static void SamplePrintOfItemsValues(ILinkedList<int> linkedList)
        {
            var firstItem = linkedList.FirstItem;
            Console.WriteLine("First item value: {0}", firstItem.Value);

            var secondItem = firstItem.NextItem;
            Console.WriteLine("Second item value: {0}", secondItem.Value);

            var thirdItem = secondItem.NextItem;
            Console.WriteLine("Third item value: {0}", thirdItem.Value);
        }
    }
}
