using System;
using System.Collections.Generic;
using System.Text;

namespace task1
{ 
    class HashTable : IHashTable
    {
        int hashArg;
        public LinkedList<int> HashLists { get; set; }
        /// <summary>
        /// Creates a new instance of HashTable with newValue % <paramref name="hashArg"/> hash function
        /// </summary>
        /// <param name="hashArg">Hash function arguement</param>
        public HashTable(int hashArg)
        {
            this.hashArg = hashArg;
            HashLists = new LinkedList<int>();
            CreateHashLists();
        }

        private void CreateHashLists()
        {
            for (int i = 0; i < hashArg; i++)
            {
                HashLists.Add(i);
            }
        }

        public void Insert(int newValue)
        {
            int newHash = newValue % hashArg;

            foreach (var hashList in HashLists)
            {
                if (hashList.Hash == newHash)
                {
                    hashList.Add(newValue);
                }
            }
        }
    }
}
