using System;
using System.Collections;
using System.Collections.Generic;

namespace DequeLibrary
{
    public class Deque<T> : IEnumerable<T>
    {
        private class Node
        {
            public T Value { get; set; }
            public Node? Next { get; set; }
            public Node? Prev { get; set; }

            public Node(T value)
            {
                Value = value;
            }
        }

        private Node? head;
        private Node? tail;
        public int Count { get; private set; }

        public event Action? CollectionCleared;
        public event Action<T>? ElementAdded;
        public event Action<T>? ElementRemoved;

        public void AddFirst(T item)
        {
            var node = new Node(item);
            if (head == null)
            {
                head = tail = node;
            }
            else
            {
                node.Next = head;
                head.Prev = node;
                head = node;
            }
            Count++;

            ElementAdded?.Invoke(item);
        }

        public void AddLast(T item)
        {
            var node = new Node(item);
            if (tail == null)
            {
                head = tail = node;
            }
            else
            {
                node.Prev = tail;
                tail.Next = node;
                tail = node;
            }
            Count++;

            ElementAdded?.Invoke(item);
        }

        public T RemoveFirst()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Deque is empty");
            }

            T value = head.Value;
            head = head.Next;
            if (head != null)
            {
                head.Prev = null;
            }
            else
            {
                tail = null;
            }
            Count--;

            ElementRemoved?.Invoke(value);
            return value;
        }

        public T RemoveLast()
        {
            if (tail == null)
            {
                throw new InvalidOperationException("Deque is empty");
            }

            T value = tail.Value;
            tail = tail.Prev;

            if (tail != null)
            {
                tail.Next = null;
            }
            else
            {
                head = null;
            }

            Count--;

            ElementRemoved?.Invoke(value);
            return value;
        }

        public bool Contains(T item)
        {
            var current = head;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.Value, item))
                {
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public void Clear()
        {
            head = tail = null;
            Count = 0;
            CollectionCleared?.Invoke();
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
