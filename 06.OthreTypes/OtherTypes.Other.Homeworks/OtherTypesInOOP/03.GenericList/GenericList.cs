using System;
using System.Linq;
using System.Text;
using System.Threading;

namespace _03.GenericList
{
    [Version(6, 7)]
    public class GenericList<T>
    {
        public const int DefaultListCapacity = 16;

        private T[] array;
        private int count;

        public GenericList(int initialCapacity = DefaultListCapacity)
        {
            this.array = new T[DefaultListCapacity];
            this.count = 0;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || this.count <= index)
                {
                    throw new IndexOutOfRangeException("Index out of accepted range for list.");
                }
                
                
                return this.array[index];
            }
        }

        public static T Min<T>(GenericList<T> list)
            where T : IComparable
        {
            T min = default(T);
            for (int index = 0; index < list.count; index++)
            {
                if (min.CompareTo(default(T)) == 0 || min.CompareTo(list[index]) == 1)
                {
                    min = list[index];
                }
            }

            return min;
        }

        public static T Max<T>(GenericList<T> list)
            where T : IComparable
        {
            T max = default(T);
            for (int index = 0; index < list.count; index++)
            {
                if (max.CompareTo(default(T)) == 0 || max.CompareTo(list[index]) == -1)
                {
                    max = list[index];
                }
            }

            return max;
        }

        public void Add(T elementToAdd)
        {
            if (this.count + 1 >= this.array.Length)
            {
                this.ResizeList();
            }
            this.array[this.count] = elementToAdd;

            this.count++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || this.count < index)
            {
                throw new ArgumentOutOfRangeException("index", "Index is out of the range of the list.");
            }

            T[] newArray = new T[this.array.Length];

            Array.Copy(this.array, 0, newArray, 0, index);
            Array.Copy(this.array, index + 1, newArray, index, this.array.Length - index - 1);

            this.count--;
            this.array = newArray;
        }

        public void InsertAt(int index, T newElement)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index", "Index is out of the range of the list.");
            }

            while (index + 1 >= this.array.Length)
            {
                this.ResizeList();
            }

            T[] newArray = new T[this.array.Length];

            Array.Copy(this.array, 0, newArray, 0, index);

            newArray[index] = newElement;

            if (index > this.count)
            {
                this.count = index + 1;
            }
            else
            {
                this.count++;
                Array.Copy(this.array, index + 1, newArray, index + 1, this.array.Length - index - 1);
            }
            
            this.array = newArray;
        }

        public void Clear()
        {
            this.array = new T[this.array.Length];
        }

        public int IndexOf(T givenElement)
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                if (this.array[i].Equals(givenElement))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(T givenElement)
        {
            bool contains = IndexOf(givenElement) != -1;
            return contains;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("{ ");

            for (int i = 0; i < this.count; i++)
            {
                result.Append(this.array[i]);

                if (i != this.count - 1)
                {
                    result.Append(", ");
                }
            }

            result.Append(" }");
            return result.ToString();
        }

        private void ResizeList()
        {
            int newArrrraySize = this.array.Length * 2;
            T[] newArray = new T[newArrrraySize];

            for (int i = 0; i < this.array.Length; i++)
            {
                newArray[i] = this.array[i];
            }

            this.array = newArray;
        }
    }
}