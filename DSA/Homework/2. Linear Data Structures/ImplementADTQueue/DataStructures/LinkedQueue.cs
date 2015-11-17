namespace ImplementADTQueue.DataStructures
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Interfaces;

    public class LinkedQueue<T> : ILinkedQueue<T>
    {
        private LinkedList<T> encapsulatedList;

        public LinkedQueue()
        {
            this.encapsulatedList = new LinkedList<T>();
        }
 
        public int? Count
        {
            get { return this.encapsulatedList.Count; }
        }

        public void Enqueue(T element)
        {
            this.encapsulatedList.AddLast(element);
        }

        public T Dequeue()
        {
            if (this.IsEmpty())
            {
                throw new ArgumentNullException("Invalid operation. LinkedQueue is empty!", new ArgumentNullException());
            }

            var firstElement = this.encapsulatedList.First;
            this.encapsulatedList.RemoveFirst();

            return firstElement.Value;
        }

        public T Peek()
        {
            if (this.IsEmpty())
            {
                throw new ArgumentNullException("Invalid operation. LinkedQueue is empty!", new ArgumentNullException());
            }

            var firstElement = this.encapsulatedList.First;

            return firstElement.Value;
        }

        public bool IsEmpty()
        {
            return (this.encapsulatedList == null || !this.encapsulatedList.Any() || this.encapsulatedList.Count == 0);
        }
    }
}
