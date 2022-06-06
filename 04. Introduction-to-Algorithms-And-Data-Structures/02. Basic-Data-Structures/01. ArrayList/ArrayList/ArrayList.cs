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

        // Time Complexity = O(1)
        // Space Complexity = O(initialCapacity)
        public ArrayList()
        {
            elements = new int[initialCapacity];
            capacity = initialCapacity;
            size = 0;
        }

        // Time Complexity = O(1) амортезирана
        // Space Complexity = O(1) Забележка: за целият клас ще имаме O(n) space, къдено n е броят на въведените елементи
        public void Add(int newElement)
        {
            if(size == capacity)
                ExtendArray();
            elements[size] = newElement;
            size++;
        }

        // Time Complexity = O(n)
        // Space Complexity = O(1)
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

        // Time Complexity = O(n)
        // Space Complexity = O(n)
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

        // Time Complexity = O(n)
        // Space Complexity = O(1)
        public bool Contains(int element)
        {
            return IndexOfElement(element) != -1;
        }

        // Time Complexity = O(1)
        // Space Complexity = O(1)
        public int GetByIndex(int index)
        {
            if (index < 0 || index >= size)
                throw new Exception("Invalid Index");
            return elements[index];
        }

        // Time Complexity = O(1)
        // Space Complexity = O(1)
        public bool SetByIndex(int index, int element)
        {
            if (index < 0 || index >= size)
                throw new Exception("Invalid index");
            elements[index] = element;
            return true;
        }

        // Time Complexity = O(N)
        // Space Complexity = O(1)
        private int IndexOfElement(int element)
        {
            for (int i = 0; i < size; i++)
            {
                if (Compare(elements[i], element))
                    return i;
            }
            return -1;
        }

        // Time Complexity = O(1)
        // Space Complexity = O(1)
        private bool Compare<T>(T first, T second)
        {
            return EqualityComparer<T>.Default.Equals(first, second);
        }

        // Time Complexity = O(n/2)
        // Space Complexity = O(n/2)
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
				elements = newSource;
            }
        }

        // Time Complexity = O(n)
        // Space Complexity = O(n)
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