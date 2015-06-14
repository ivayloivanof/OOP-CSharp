using System;
using System.Linq;

namespace GenericList.Class
{
    class GenericList<T> 
        where T : IComparable<T>, IEquatable<T>
    {
        private const int defaultmemory = 5;
        private T[] elements;
        private int buffer;
        private int elementIndex;

        public GenericList(int memory = defaultmemory)
        {
            this.elements = new T[defaultmemory];
            this.Buffer = memory;
        }

        public int Buffer
        {
            get { return this.buffer; }
            set
            {
                if (value < defaultmemory)
                    this.buffer = defaultmemory;
                if (value < 0)
                    throw new ArgumentOutOfRangeException("buffer", "Buffer cannot be negative!");
                this.buffer = value;
            }
        }

        public void Add(T element)
        {
            if (this.elementIndex >= elements.Length)
            {
                buffer = buffer * 2;
                T[] e = new T[buffer];
                for (int i = 0; i < elements.Length; i++)
                {
                    e[i] = this.elements[i];
                }
                this.elements = e;
            }
            this.elements[this.elementIndex] = element;
            this.elementIndex++;
        }

        public void Remove(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index", "Index cannot be negative!");
            }
            this.elements[index] = default (T);
            for (int i = index; i < elements.Length - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.elements[elements.Length-1] = default (T);
        }

        public int Finding(T value)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (this.elements[i].Equals(value))
                {
                    return i;   //return position
                }
            }
            return -1;  //not founded
        }

        public void Clear()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.elements[i] = default(T);
            }
            this.buffer = defaultmemory;
            this.elementIndex = 0;
            this.elements = new T[defaultmemory];
        }

        public int Count()
        {
            return this.elementIndex;
        }

        public T Max()
        {
            if (this.elementIndex == 0)
            {
                throw new InvalidOperationException("GenericList is empty");
            }

            T max = this.elements[0];
            for (int i = 1; i < this.elementIndex; i++)
            {
                T current = this.elements[i];
                if (current.CompareTo(max) == 1)
                {
                    max = current;
                }
            }

            return max;
        }

        //public int T Min()
        //{
            
        //}

        public override string ToString()
        {
            return string.Format(string.Join(", ", (from item in elements
                                                    where !item.Equals(default (T))
                                                    select item)));
        }
    }
}
