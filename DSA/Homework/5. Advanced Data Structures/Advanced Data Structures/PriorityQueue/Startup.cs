namespace PriorityQueueWithBinaryHeap
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var set = new PriorityQueue<int>();
            set.Enqueue(5);
            set.Enqueue(10);
            set.Enqueue(15);
            Console.WriteLine(set.Count);
        }
    }
}
