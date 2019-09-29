using System;
using System.Collections;
using System.Collections.Generic;

namespace task1
{
    class HashList<T>
    {
        public ListNode<T> Head { get; set; }
        public ListNode<T> Tail { get; set; }
        public T Hash { get; set; }
        public HashList<T> Next { get; set; }

        public void Add(T value)
        {
            var newNode = new ListNode<T>(value);
            if (Head == null)
                Head = Tail = newNode;
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = Head; i != null; i = i.Next)
                yield return i.Value;
        }
    }
}
