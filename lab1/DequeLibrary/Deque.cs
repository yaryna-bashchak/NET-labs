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
        public event Action? CollectionBecameEmpty;
        public event Action<T>? ElementAdded;
        public event Action<T>? ElementRemoved;
        public event Action? CollectionCopied;

        public Deque()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public Deque(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            foreach (var item in collection)
            {
                AddLast(item);
            }
        }

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
                throw new InvalidOperationException("Error: you are trying to remove first when deque is empty");
            }

            T value = head.Value;
            head = head.Next;

            Count--;
            ElementRemoved?.Invoke(value);

            if (head != null)
            {
                head.Prev = null;
            }
            else
            {
                tail = null;
                CollectionBecameEmpty?.Invoke();
            }

            return value;
        }

        public T RemoveLast()
        {
            if (tail == null)
            {
                throw new InvalidOperationException("Error: you are trying to remove last when deque is empty");
            }

            T value = tail.Value;
            tail = tail.Prev;

            Count--;
            ElementRemoved?.Invoke(value);

            if (tail != null)
            {
                tail.Next = null;
            }
            else
            {
                head = null;
                CollectionBecameEmpty?.Invoke();
            }

            return value;
        }

        public void CopyTo(T[] array, int index = 0)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (index < 0 || index >= array.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range");
            }

            if (array.Length - index < Count)
            {
                throw new ArgumentException("Deque size is bigger than array length");
            }

            var current = head;
            int currentIndex = index;

            while (current != null)
            {
                if (currentIndex >= array.Length) break;

                array[currentIndex] = current.Value;

                current = current.Next;
                currentIndex++;
            }

            CollectionCopied?.Invoke();
        }

        public bool TryRemoveFirst(out T? item)
        {
            if (head == null)
            {
                item = default;
                return false;
            }

            item = RemoveFirst();
            return true;
        }

        public bool TryRemoveLast(out T? item)
        {
            if (tail == null)
            {
                item = default;
                return false;
            }

            item = RemoveLast();
            return true;
        }

        public T PeekFirst()
        {
            if (head == null)
            {
                throw new InvalidOperationException("Error: you are trying to peek first when deque is empty");
            }

            T value = head.Value;

            return value;
        }

        public T PeekLast()
        {
            if (tail == null)
            {
                throw new InvalidOperationException("Error: you are trying to peek last when deque is empty");
            }

            T value = tail.Value;

            return value;
        }

        public bool TryPeekFirst(out T? item)
        {
            if (head == null)
            {
                item = default;
                return false;
            }

            item = head.Value;
            return true;
        }

        public bool TryPeekLast(out T? item)
        {
            if (tail == null)
            {
                item = default;
                return false;
            }

            item = tail.Value;
            return true;
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
            CollectionBecameEmpty?.Invoke();
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

        public void Print()
        {
            foreach (var item in this)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
