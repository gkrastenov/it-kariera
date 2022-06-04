using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomArrayList
{
    public class ArrayList
    {
        private const int initialCapacity = 8;
        private const int extend = 2;

        private int capacity;
        private int size;
        private int[] elements;

        // Time Complexity = ?
        // Space Complexity = ?
        public ArrayList()
        {
            elements = new int[initialCapacity];
            capacity = initialCapacity;
            size = 0;
        }

        // Time Complexity = ?
        // Space Complexity = ?
        public void Add(int newElement)
        {
            if(size == capacity)
                ExtendArray();
            elements[size] = newElement;
            size++;
        }

        // Time Complexity = ?
        // Space Complexity = ?
        public void Remove(int element)
        {
            int index = IndexOfElement(element);
            if (index == -1)
                throw new Exception("Not founded");

            if(index != size - 1) // 1 2 3
            {
                for (int i = index; i < size - 1; i++)
                {
                    elements[i] = elements[i + 1];
                }
            }
            ShrinkArray(); // we can reduce memory if we have too much
            size--;
        }

        // Time Complexity = ?
        // Space Complexity = ?
        private void ExtendArray()
        {
            capacity *= extend;
            int[] newSource = new int[capacity];
            for (int i = 0; i < size; i++)
            {
                newSource[i] = elements[i];
            }
            elements = newSource;
        }

        // Time Complexity = ?
        // Space Complexity = ?
        public bool Contains(int element)
        {
            return IndexOfElement(element) != -1;
        }

        // Time Complexity = ?
        // Space Complexity = ?
        public int GetByIndex(int index)
        {
            if (index < 0 || index >= size)
                throw new Exception("Invalid Index");
            return elements[index];
        }

        // Time Complexity = ?
        // Space Complexity = ?
        public bool SetByIndex(int index, int element)
        {
            if (index < 0 || index >= size)
                throw new Exception("Invalid index");
            elements[index] = element;
            return true;
        }

        // Time Complexity = ?
        // Space Complexity = ?
        private int IndexOfElement(int element)
        {
            for (int i = 0; i < size; i++)
            {
                if (Compare(elements[i], element))
                    return i;
            }
            return -1;
        }

        // Time Complexity = ?
        // Space Complexity = ?
        private bool Compare<T>(T first, T second)
        {
            return EqualityComparer<T>.Default.Equals(first, second);
        }

        // Time Complexity = ?
        // Space Complexity = ?
        private void ShrinkArray()
        {
            if (size * extend == capacity)
            {
                int[] newSource = new int[capacity / 2];
                for (int i = 0; i < size; i++)
                {
                    newSource[i] = elements[i];
                }
                capacity /= extend;
            }
        }

        // Time Complexity = ?
        // Space Complexity = ?
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < size; i++)
            {
                stringBuilder.AppendLine(elements[i].ToString());
            }
            return stringBuilder.ToString();
        }
    }
}