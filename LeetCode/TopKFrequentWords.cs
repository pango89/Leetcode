using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class TopKFrequentWords
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                if (!wordCount.ContainsKey(word))
                    wordCount.Add(word, 0);
                wordCount[word]++;
            }

            SortedDictionary<int, SortedSet<string>> map = new SortedDictionary<int, SortedSet<string>>(new DescendingComparer<int>());

            foreach(KeyValuePair<string, int> entry in wordCount)
            {
                string str = entry.Key;
                int count = entry.Value;

                if (!map.ContainsKey(count))
                    map.Add(count, new SortedSet<string>());

                map[count].Add(str);
            }

            IList<string> output = new List<string>();

            foreach (KeyValuePair<int, SortedSet<string>> entry in map)
            {
                if (k == 0)
                    break;

                SortedSet<string> sortedWords = entry.Value;
                foreach (string word in sortedWords)
                {
                    if (k == 0)
                        break;

                    output.Add(word);
                    k--;
                }
            }

            return output;
        }
    }

    public class DescendingComparer<T> : IComparer<T> where T : IComparable<T>
    {
        public int Compare(T x, T y)
        {
            return y.CompareTo(x);
        }
    }
}
