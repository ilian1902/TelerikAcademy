namespace ImplementADTStack.DataStructures
{
    using System;

    using Interfaces;

    public class AbstractStack<T> : IAbstractStack<T>
    {
        private const int DefaultStackSize = 4;

        private int counter;
        private int? currentIndex;
        private T[] encapsulatedArray;

        public AbstractStack()
            : this(DefaultStackSize)
        {
        }

        public AbstractStack(int size)
        {
            this.counter = size;
            this.currentIndex = null;
            this.encapsulatedArray = new T[size];
        }

        /// <summary>
        /// Return number of elements in stack
        /// </summary>
        public int? Count
        {
            get
            {
                if (this.currentIndex == null)
                {
                    return 0;
                }

                return this.currentIndex;
            }
        }

        /// <summary>
        /// Add element at start of stack
        /// </summary>
        /// <param name="element"></param>
        public void Push(T element)
        {
            if (this.currentIndex == null)
            {
                this.currentIndex = 0;
            }
            ++this.currentIndex;

            if (this.currentIndex != null)
            {
                if (this.currentIndex == this.counter)
                {
                    this.AutoIncreateSize();
                }
            }

            this.encapsulatedArray[(int)this.currentIndex] = element;
        }

        /// <summary>
        /// Remove element from stack
        /// </summary>
        /// <param name="element"></param>
        public T Pop()
        {
            if (this.currentIndex != null)
            {
                this.currentIndex--;
                return this.encapsulatedArray[(int)this.currentIndex + 1];
            }
            else
            {
                throw new ArgumentNullException("You cannot pop element! The stack is empty.",
                    new ArgumentNullException());
            }
        }

        /// <summary>
        /// Return first element from stack
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (this.currentIndex != null)
            {
                return this.encapsulatedArray[(int)this.currentIndex];
            }
            else
            {
                throw new ArgumentNullException("You cannot pop element! The stack is empty.",
                    new ArgumentNullException());
            }
        }

        /// <summary>
        /// Check if stack is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return this.currentIndex == null;
        }

        private void AutoIncreateSize()
        {
            if (this.currentIndex == null)
            {
                return;
            }

            var newArray = new T[(int)(this.currentIndex * 2)];
            Array.Copy(this.encapsulatedArray, newArray, this.encapsulatedArray.Length);

            this.encapsulatedArray = newArray;
            this.counter = this.encapsulatedArray.Length;
        }
    }
}
