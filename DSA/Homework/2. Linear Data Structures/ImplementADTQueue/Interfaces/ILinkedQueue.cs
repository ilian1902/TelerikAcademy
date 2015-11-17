namespace ImplementADTQueue.Interfaces
{
    public interface ILinkedQueue<T>
    {
        int? Count { get; }

        void Enqueue(T element);

        T Dequeue();

        T Peek();

        bool IsEmpty();
    }
}
