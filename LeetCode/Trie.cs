using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Trie
    {
        public Trie[] nodes;
        public bool isEndOfWord;

        public Trie()
        {
            this.nodes = new Trie[26];
            for (int i = 0; i < this.nodes.Length; i++)
                this.nodes[i] = null;

            isEndOfWord = false;
        }

        public void Insert(string word)
        {
            if (word.Length == 0)
                return;

            char first = word[0];

            if(!this.isEndOfWord)
                this.isEndOfWord = (word.Length == 1);

            Trie temp;
            if (this.nodes[first - 'a'] == null)
            {
                temp = new Trie();
                this.nodes[first - 'a'] = temp;
            }
            else
                temp = this.nodes[first - 'a'];

            temp.Insert(word.Substring(1));
        }

        public bool Search(string word)
        {
            char first = word[0];
            Console.WriteLine(word);

            Trie temp = this.nodes[first - 'a'];
            if (temp == null)
                return false;

            if (word.Length == 1)
                if (this.isEndOfWord)
                    return true;
                else
                    return false;

            return temp.Search(word.Substring(1));
        }

        public bool StartsWith(string prefix)
        {
            char first = prefix[0];

            Trie temp = this.nodes[first - 'a'];
            if (temp == null)
                return false;

            if (prefix.Length == 1)
                return true;

            return temp.StartsWith(prefix.Substring(1));
        }
    }
}
