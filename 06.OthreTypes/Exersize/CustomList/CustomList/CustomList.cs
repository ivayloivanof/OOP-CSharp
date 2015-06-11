namespace CustomList
{
    class CustomList <T>
    {
        const int defaultMemory = 3;
        private T[] elements;
        private int buffer;
        private int elementIndex;

        public CustomList(int memory = defaultMemory)
        {
            this.elements = new T[defaultMemory];
            this.buffer = memory;
            this.elementIndex = 0;
        }

        public void Add(T element)
        {
            if (this.elementIndex >= elements.Length)
            {
                buffer = buffer*2;
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

        public void Clear()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                this.elements[i] = default (T);
            }
            buffer = defaultMemory;
            this.elementIndex = 0;
            this.elements = new T[defaultMemory];
        }

        public int Count()
        {
            return this.elementIndex;
        }

    }
}
