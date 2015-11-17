namespace PriorityQueueWithBinaryHeap
{
    using System;
    using System.Collections.Generic;

    public class PriorityQueue<T> where T : IComparable
    {
        private List<T> storedValues;

        public PriorityQueue()
        {
            this.storedValues = new List<T>();
            this.storedValues.Add(default(T));
        }

        public virtual int Count
        {
            get
            {
                return this.storedValues.Count - 1;
            }
        }

        public virtual T Peek()
        {
            if (this.Count == 0)
            {
                return default(T);
            }
            else
            {
                return this.storedValues[1];
            }
        }

        public virtual void Enqueue(T value)
        {
            this.storedValues.Add(value);
            this.BubbleUp(this.storedValues.Count - 1);
        }

        public virtual T Dequeue()
        {
            if (this.Count == 0)
            {
                return default(T);
            }
            else
            {
                T minValue = this.storedValues[1];

                if (this.storedValues.Count > 2)
                {
                    T lastValue = this.storedValues[this.storedValues.Count - 1];
                    this.storedValues.RemoveAt(this.storedValues.Count - 1);
                    this.storedValues[1] = lastValue;
                    this.BubbleDown(1);
                }
                else
                {
                    this.storedValues.RemoveAt(1);
                }

                return minValue;
            }
        }

        protected virtual void BubbleUp(int startCell)
        {
            int cell = startCell;

            while (this.IsParentBigger(cell))
            {
                T parentValue = this.storedValues[cell / 2];
                T childValue = this.storedValues[cell];

                this.storedValues[cell / 2] = childValue;
                this.storedValues[cell] = parentValue;

                cell /= 2;
            }
        }

        protected virtual void BubbleDown(int startCell)
        {
            int cell = startCell;

            while (this.IsLeftChildSmaller(cell) || this.IsRightChildSmaller(cell))
            {
                int child = this.CompareChild(cell);

                if (child == -1)
                {
                    T parentValue = this.storedValues[cell];
                    T leftChildValue = this.storedValues[2 * cell];

                    this.storedValues[cell] = leftChildValue;
                    this.storedValues[2 * cell] = parentValue;

                    cell = 2 * cell;
                }
                else if (child == 1)
                {
                    T parentValue = this.storedValues[cell];
                    T rightChildValue = this.storedValues[(2 * cell) + 1];

                    this.storedValues[cell] = rightChildValue;
                    this.storedValues[(2 * cell) + 1] = parentValue;

                    cell = (2 * cell) + 1;
                }
            }
        }

        protected virtual bool IsParentBigger(int childCell)
        {
            if (childCell == 1)
            {
                return false;
            }
            else
            {
                return this.storedValues[childCell / 2].CompareTo(this.storedValues[childCell]) > 0;
            }
        }

        protected virtual bool IsLeftChildSmaller(int parentCell)
        {
            if (2 * parentCell >= this.storedValues.Count)
            {
                return false;
            }
            else
            {
                return this.storedValues[2 * parentCell].CompareTo(this.storedValues[parentCell]) < 0;
            }
        }

        protected virtual bool IsRightChildSmaller(int parentCell)
        {
            if ((2 * parentCell) + 1 >= this.storedValues.Count)
            {
                return false;
            }
            else
            {
                return this.storedValues[(2 * parentCell) + 1].CompareTo(this.storedValues[parentCell]) < 0;
            }
        }

        protected virtual int CompareChild(int parentCell)
        {
            bool leftChildSmaller = this.IsLeftChildSmaller(parentCell);
            bool rightChildSmaller = this.IsRightChildSmaller(parentCell);

            if (leftChildSmaller || rightChildSmaller)
            {
                if (leftChildSmaller && rightChildSmaller)
                {
                    int leftChild = 2 * parentCell;
                    int rightChild = (2 * parentCell) + 1;

                    T leftValue = this.storedValues[leftChild];
                    T rightValue = this.storedValues[rightChild];

                    if (leftValue.CompareTo(rightValue) <= 0)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else if (leftChildSmaller)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
