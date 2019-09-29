using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class LinkedList<T>
    {
        public HashList<T> Head;
        public HashList<T> Tail;

        public void Add(T newHash)
        {
            HashList<T> newList = new HashList<T>();
            newList.Hash = newHash;
            if (Head == null)
                Head = Tail = newList;
            else
            {
                Tail.Next = newList;
                Tail = newList;
            }
        }

        public IEnumerator<HashList<T>> GetEnumerator()
        {
            for (var i = Head;  i != null; i = i.Next)
                yield return i;
        }
    }
}
