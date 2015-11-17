namespace ImplementADTQueue
{
    using Interfaces;
    using DataStructures;

    public class Startup
    {
        public static void Main()
        {
            TestLinkedQueue();
        }

        private static void TestLinkedQueue()
        {
            ILinkedQueue<int> linkedQueue = new LinkedQueue<int>();

            // Should return true
            var isEmpty = linkedQueue.IsEmpty();

            linkedQueue.Enqueue(1);
            linkedQueue.Enqueue(2);
            linkedQueue.Enqueue(3);
            linkedQueue.Enqueue(4);
            // Should have 4 elements

            // Should remove first added element - (1) and return it
            var removedElement = linkedQueue.Dequeue();

            // Should return first element - (2)
            var firstElement = linkedQueue.Peek();

            // Should return 3
            var count = linkedQueue.Count;

            // Should return false
            isEmpty = linkedQueue.IsEmpty();
        }
    }
}
