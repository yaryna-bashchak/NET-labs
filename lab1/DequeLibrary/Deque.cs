﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace DequeLibrary
{
    public class Deque<T>
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
            return value;
        }
    }
}