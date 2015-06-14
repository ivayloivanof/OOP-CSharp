using System;

namespace GenericList.Class
{
    class GenericList<T>
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
            this.elements[index] = default (T);
            for (int i = index; i < elements.Length - 1; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.elements[elements.Length-1] = default (T);
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



    }
}
