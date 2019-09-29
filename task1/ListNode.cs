using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class ListNode<T> : IListNode<T>
    {
        public T Value { get; set; }
        public ListNode<T> Next { get; set; }

        public ListNode(T value)
        {
            Value = value;
            Next = null;
        }

        public void Insert(T newValue)
        {
            Value = newValue;
        }
    }
}
