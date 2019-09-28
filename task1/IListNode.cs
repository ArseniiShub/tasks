using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{ 
    interface IListNode<T>
    {
        ListNode<T> Next { get; set; }
        T Value { get; set; }
        void Insert(T newValue);
    }
}
