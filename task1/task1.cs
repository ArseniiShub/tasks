using System;
using System.Collections.Generic;
using System.Linq;

namespace task1
{
    class task1
    {
        static void Main(string[] args)
        {
            string hashArg = Console.ReadLine().Split(' ')[0];
            var tokens = Console.ReadLine().Split(' ');

            HashTable hashTable = new HashTable(Convert.ToInt32(hashArg));

            foreach (var token in tokens)
            {
                if(!String.IsNullOrWhiteSpace(token))
                    hashTable.Insert(Convert.ToInt32(token));
            }

            foreach (var hashList in hashTable.HashLists)
            {
                Console.Write(hashList.Hash + ": ");
                foreach (var item in hashList)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
