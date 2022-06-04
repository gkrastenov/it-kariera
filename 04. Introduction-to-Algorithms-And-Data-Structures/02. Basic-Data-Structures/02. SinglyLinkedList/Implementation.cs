using System;
using System.Collections;
using System.Collections.Generic;

namespace SinglyLinkedList
{
    public class SinglyLinkedList<T>
    {
        public class Node<T>
        {
            public T Value { get; set; }
            public Node<T> Next { get; set; }

            public Node(T value, Node<T> next = null)
            {
                this.Value = value;
                this.Next = next;
            }
        }

        private Node<T> head;

        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            Node<T> node = new Node<T>(value);
            if (head != null)
            {
                this.head = node;
            }
            else
            {
                node.Next = this.head;
                this.head = node;
            }
            this.head = node;
            this.Count++;
        }

        public void AddLast(T item)
        {
            Node<T> node = new Node<T>(item);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                var current = this.head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }

            this.Count++;
        }

        public T GetFirst()
        {
            IsEmpty();
            return this.head.Item;
        }

        public T GetLast()
        {
            IsEmpty();

            var current = this.head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current.Item;
        }

        public T RemoveFirst()
        {
            IsEmpty();
            var toReturnItem = this.head.Item;
            this.head = this.head.Next;
            this.Count--;

            return toReturnItem;
        }

        public T RemoveLast()
        {
            IsEmpty();

            var current = this.head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            var toReturn = current.Item;
            current = null;
            return toReturn;
        }
    }
}