using System;
using System.Collections;
using System.Collections.Generic;

namespace task1
{
    class CustomList<T> 
    {
        public ListNode<T> Head;
        public ListNode<T> Tail;
        public T Hash;
        public CustomList<T> Next { get; set; }

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

        public bool Contains(T value)
        {
            foreach (var item in this)
            {
                if(value.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = Head; i != null; i = i.Next)
                yield return i.Value;
        }
    }
}
