using System;

namespace StackImplementation
{
    public class Stack<T>
    {
        public static readonly int capacity = 1000;
        public static readonly int size = 0;

        public Stack()
        {
            T[] elements = new T[capacity];
        }

        public bool IsEmpty() => return (size != 0);

        public bool Push(T newElement)
        {
            if (size >= capacity)
                throw new StackOverflowException();
            elements[++size] = newElement;
            return true;
        }

        public T Pop()
        {
            if (size < 0)
                throw new Exception("Stack Underflow")
            return elements[size--];
        }

        public T Peek()
        {
            if (size < 0)
                throw new Exception("Stack Underflow");
            return elements[size - 1];
        }
    }
}