using System;
using System.Collections;
using System.Collections.Generic;

namespace DoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public class Node<T>
        {
            public T Value { get; set; }

            public Node<T> Next { get; set; }

            public Node<T> Previous { get; set; }

        }

        private Node<T> Head;
        private Node<T> Tail;

        public DoublyLinkedList(Node<T> head)
        {
            this.Head = this.Tail = head;
            this.Count++;
        }

        public DoublyLinkedList()
        {
            this.Head = this.Tail = null;
            this.Count = 0;
        }

        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            Node<T> node = new Node<T>()
            {
                Value = value
            };

            if (this.Count == 0)
            {
                this.Head = this.Tail = node;
            }
            else
            {
                Head.Previous = node;
                node.Next = Head;
                Head = node;
            }

            this.Count++;
        }

        public void AddLast(T value)
        {
            Node<T> node = new Node<T>()
            {
                Value = value
            };

            if (this.Count == 0)
            {
                this.Head = this.Tail = node;
            }
            else
            {
                node.Previous = Tail;
                Tail.Next = node;
                Tail = node;
            }

            this.Count++;
        }

        public T GetFirst()
        {
            IsEmpty();
            return this.Head.Value;
        }

        public T GetLast()
        {
            IsEmpty();
            return this.Tail.Value;
        }

        public T RemoveFirst()
        {
            IsEmpty();

            var toIntern = this.Head.Value;
            this.Head = this.Head.Next;

            this.Count--;
            return toIntern;
        }

        public T RemoveLast()
        {
            IsEmpty();

            var toIntern = this.Tail.Value;
            this.Tail = this.Tail.Previous;

            this.Count--;
            return toIntern;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        private void IsEmpty()
        {
            if (this.Head == null || this.Count == 0)
            {
                throw new InvalidOperationException();
            }
        }
    }
}