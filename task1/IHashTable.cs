using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{
    interface IHashTable
    {
        CustomHashList<int> HashLists { get; set; }
        void Insert(int newValue);
    }
}
