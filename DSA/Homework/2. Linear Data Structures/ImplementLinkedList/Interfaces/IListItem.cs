namespace ImplementLinkedList.Interfaces
{
    public interface IListItem<T>
    {
        T Value { get; set; }

        IListItem<T> NextItem { get; set; }
    }
}
