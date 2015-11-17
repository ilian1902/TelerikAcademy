namespace ImplementADTStack.Interfaces
{
    public interface IAbstractStack<T>
    {
        int? Count { get; }

        void Push(T element);

        T Pop();

        T Peek();

        bool IsEmpty();
    }
}
