namespace DefiningClassesPartTwoProblem567
{
    using System;
    using System.Text;

    // Problem 5
    public class GenericList<T> where T : IComparable, new()
    {
        private const int DefoltCapacity = 8;

        private T[] genericList;
        private int capacity;
        private int count;

        public int Capacity
        {
            get { return this.capacity; }
            private set { this.capacity = value; }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
            private set
            {
                this.count = value;
            }
        }

        public GenericList(int capacity)
        {
            this.genericList = new T[capacity];
            this.Capacity = capacity;
            this.count = 0;
        }

        public GenericList()
            : this(DefoltCapacity)
        {

        }
        public T this[int index]
        {
            get
            {
                CheckIfPositionIsCorrect(index);
                return this.genericList[index];
            }
            set
            {
                CheckIfPositionIsCorrect(index);
                this.genericList[index] = value;
            }
        }

        public void Add(T element)// Problem 5
        {
            if (this.Count >= this.genericList.Length - 1)
            {
                AutoDoubleSize();
            }
            this.genericList[Count] = element;
            this.Count++;
        }

        public T RemoveAt(int index)//Problem 5
        {
            CheckIfPositionIsCorrect(index);
            T result = genericList[index];
            for (int i = index; i < this.Count - 1; i++)
            {
                this.genericList[i] = this.genericList[i + 1];
            }
            this.genericList[this.Count - 1] = new T();
            this.Count--;
            return result;
        }
        // trqbva da go oprawq
        public void InsertAt(T element, int index)// Problem 5
        {
            if (index < 0 || index >= this.genericList.Length - 1)
            {
                this.AutoDoubleSize();
            }
            if (index == this.Count)
            {
                this.Add(element);
                return;
            }

            if (this.Count >= this.genericList.Length - 1)
            {
                this.AutoDoubleSize();
            }

            this.Count++;

            for (int i = this.Count; i > index; i--)
            {
                this.genericList[i] = this.genericList[i - 1];
            }

            this.genericList[index] = element;
        }
        
        public int IndexOf(T element)// Problem 5
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.genericList[i].Equals(element))
                {
                    return i;
                    break;
                }
            }
            return -1;
        }

        public void ClearList()//Problem 5 
        {
            this.genericList = new T[DefoltCapacity];
            this.Count = 0;
            this.Capacity = DefoltCapacity;
        }

        public override string ToString()// Problem 5
        {
            StringBuilder result = new StringBuilder();

            foreach (var T in this.genericList)
            {
                result.Append(string.Join(", ", T));
            }
            return result.ToString();
        }

        private void AutoDoubleSize()// Problem 6
        {
            T[] newList = new T[this.genericList.Length * 2];
            Array.Copy(this.genericList, newList, this.genericList.Length);
            this.genericList = newList;
        }

        public T Min() //problem7
        {
            T min = this.genericList[0];
            for (int i = 0; i < count; i++)
            {
                if (this.genericList[i].CompareTo(min) < 0)
                {
                    min = this.genericList[i];
                }
            }
            return min;
        }

        public T Max() //problem7
        {
            T max = this.genericList[0];
            for (int i = 0; i < count; i++)
            {
                if (this.genericList[i].CompareTo(max) > 0)
                {
                    max = this.genericList[i];
                }
            }
            return max;
        }

        private void CheckIfPositionIsCorrect(int index)
        {
            if (index < 0 || index >= genericList.Length)
            {
                throw new ArgumentOutOfRangeException("Index was out of range");
            }
        }
    }
}
