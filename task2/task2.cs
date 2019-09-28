using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task2
{
    class task2
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            string[] tokens;
            const int maxAsterix = 10;

            tokens = Console.ReadLine().Split(' ');

            foreach (var word in tokens)
            {
                if (words.ContainsKey(word))
                    words[word]++;
                else
                    words.Add(word, 1);
            }

            int maxString = words.Keys.Max(x => x.Length);
            double maxNum = words.Values.Max();
            words = words.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var word in words)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(new String('_', maxString - word.Key.Length));
                stringBuilder.Append(word.Key);
                stringBuilder.Append('.', Convert.ToInt32(Math.Round(word.Value / maxNum * maxAsterix)));
                Console.WriteLine(stringBuilder);
            }
        }
    }
}
