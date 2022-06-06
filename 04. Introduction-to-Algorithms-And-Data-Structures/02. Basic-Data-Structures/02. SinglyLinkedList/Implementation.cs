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
			
			// Time Complexity = ?
            // Space Complexity = ?
            public Node(T value, Node<T> next = null)
            {
                this.Value = value;
                this.Next = next;
            }
        }

        private Node<T> Head;

        public int Count { get; private set; }

        // Time Complexity = O(1)
        // Space Complexity = O(1)
        public void AddFirst(T value)
        {
            Node<T> node = new Node<T>(value);
            if (Head != null)
            {
                this.Head = node;
            }
            else
            {
                node.Next = this.Head;
                this.Head = node;
            }
            this.Head = node;
            this.Count++;
        }

        // Time Complexity = O(n)
        // Space Complexity = O(1)
        public void AddLast(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.Head == null)
            {
                this.Head = node;
            }
            else
            {
                var current = this.Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = node;
            }

            this.Count++;
        }

        // Time Complexity = O(1)
        // Space Complexity = O(1)
        public T GetFirst()
        {
            IsEmpty();
            return this.Head.Value;
        }

        // Time Complexity = O(n)
        // Space Complexity = O(1)
        public T GetLast()
        {
            IsEmpty();

            var current = this.Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            return current.Value;
        }

        // Time Complexity = O(1)
        // Space Complexity = O(1)
        public T RemoveFirst()
        {
            IsEmpty();

            var toReturnValue = this.Head.Value;
            this.Head = this.Head.Next;
            this.Count--;
            return toReturnValue;
        }

        // Time Complexity = O(n)
        // Space Complexity = O(1)
        public T RemoveLast()
        {
            IsEmpty();

            var current = this.Head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            var toReturn = current.Value;
            current = null;
            return toReturn;
        }

        // Time Complexity = O(1)
        // Space Complexity = O(1)
        public void IsEmpty()
		{
			if(size == 0)
				throw new Exception("Empty linked list");
		}
    }
}