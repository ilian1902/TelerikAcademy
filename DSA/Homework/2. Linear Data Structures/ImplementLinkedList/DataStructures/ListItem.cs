namespace ImplementLinkedList.DataStructures
{
    using Interfaces;

    public class ListItem<T> : IListItem<T>
    {
        public T Value { get; set; }

        public IListItem<T> NextItem { get; set; }
    }
}
