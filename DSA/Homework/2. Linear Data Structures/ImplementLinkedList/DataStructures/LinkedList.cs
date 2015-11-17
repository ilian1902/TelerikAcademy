namespace ImplementLinkedList.DataStructures
{
    using Interfaces;

    public class LinkedList<T> : ILinkedList<T>
    {
        public IListItem<T> FirstItem { get; set; }
    }
}
