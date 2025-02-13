﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class GenericList<T>:IEnumerable where T:IComparable<T>
    {
        private const int Default = 16;
        private T[] elements;
        private int count;

        public GenericList(int capacity=Default)
        {
            this.elements=new T[capacity];
            this.count = 0;
        }
        public int Count
        {
            get { return this.count; }
        }
        public T this[int index]
        {
            get
            {
                if(this.count==0)
                {
                    throw new InvalidCastException("List is empty");
                }
                if(index<0||index>=count)
                {

                } throw new ArgumentOutOfRangeException("Invalid index");
                return this.elements[index];
            }
            set
            {
                this.elements[index]=value;
            }
        }
        public void Add(T element)
        {
            if(this.count==this.elements.Length)
            {
                this.Resize();
            }
            this.elements[this.count] = element;
            this.count++;
        }
        public void Remove(int index)
        {
            if(this.count==0)
            {
                throw new InvalidOperationException("List is empty");
            }
            if(index<0|| index>=this.count)
            {
                throw new ArgumentOutOfRangeException("Invalid index");
            }
            for (int i = index; i <this.count; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }
            this.count--;
        }
        public void Insert(T element,int index)
        {
            if(this.count==0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            if(index<0||this.count>this.count)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
            if(this.count==this.elements.Length)
            {
                this.Resize();
            }
            for (int i = this.count; i < index; i++)
            {
                this.elements[i] = this.elements[i - 1];
            }
            this.elements[index] = element;
            this.count++;
        }
        public void Clear()
        {
            for (int i = 0; i < this.count; i++)
            {
                this.elements[i] = default(T);
            }
            this.count = 0;
        }
        public int FindIndex(T element)
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("List is empty");
            }
            for (int i = 0; i < this.count; i++)
            {
                T currentElement = this.elements[i];
                if(currentElement.Equals(element))
                {
                    return i;
                }
            }
            return -1;
        }
        public bool Contains(T element)
        {
            for (int i = 0; i < this.count; i++)
            {
                T currentElement = this.elements[i];
                if (currentElement.Equals(element))
                {
                    return true;
                }
            }

            return false;
        }
        public T Min()
        {
            if(this.count==0)
            {
                throw new InvalidOperationException("List is empty");
            }
            T min = this.elements[0];
            for (int i = 1; i < this.count; i++)
            {
                 T currentElement = this.elements[i];
                if (currentElement.CompareTo(min) < 0)
                {
                    min = currentElement;
                }
            }
            return min;
        }
        public T Max()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("List is empty");
            }
            T max = this.elements[0];
            for (int i = 1; i < this.count; i++)
            {
                T currentElement = this.elements[i];
                if (currentElement.CompareTo(max) > 0)
                {
                    max = currentElement;
                }
            }
            return max;
        }
        public override string ToString()
        {
            var resultElements = this.elements.Take(this.count);

            return string.Join(", ", resultElements);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return this.elements.Take(this.count).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        public void Version()
        {
            Type type = typeof(GenericList<T>);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (var ver in allAttributes)
            {
                if (ver is Version)
                {
                    Version temp = ver as Version;
                    Console.WriteLine("GenericList v.{0}.{1}", temp.Major, temp.Minor);
                }
            }
        }

        private void Resize()
        {
            T[] newElements = new T[this.elements.Length * 2];
            for (int i = 0; i < this.elements.Length; i++)
            {
                newElements[i] = this.elements[i];
            }

            this.elements = newElements;
        }
    }
}
