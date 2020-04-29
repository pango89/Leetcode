using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class TopKFrequent
    {
        public int[] TopKFrequent1(int[] nums, int k)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            LinkedList<int>[] buckets = new LinkedList<int>[nums.Length + 1];

            int[] output = new int[k];

            for (int i = 0; i < nums.Length; i++)
            {
                int key = nums[i];
                if (!dict.ContainsKey(key))
                    dict[key] = 1;
                else
                    dict[key]++;
            }

            foreach (KeyValuePair<int, int> item in dict)
            {
                if (buckets[item.Value] == null)
                    buckets[item.Value] = new LinkedList<int>();
                buckets[item.Value].AddLast(item.Key);
            }

            int c = 0;
            for (int i = buckets.Length - 1; i > 0; i--)
            {
                if (c >= k)
                    break;

                if (buckets[i] != null) {
                    while (buckets[i].Count > 0)
                    {
                        if (c >= k)
                            break;

                        output[c++] = buckets[i].First();
                        buckets[i].RemoveFirst();
                    }
                }
            }
        
            return output;
        }
    }
}
