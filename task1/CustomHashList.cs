using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    class CustomHashList<T>
    {
        public CustomList<T> Head;
        public CustomList<T> Tail;

        public void Add(T newHash)
        {
            CustomList<T> newList = new CustomList<T>();
            newList.Hash = newHash;
            if (Head == null)
                Head = Tail = newList;
            else
            {
                Tail.Next = newList;
                Tail = newList;
            }
        }

        public IEnumerator<CustomList<T>> GetEnumerator()
        {
            for (var i = Head;  i != null; i = i.Next)
                yield return i;
        }
    }
}
