using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Subset
    {
        public void SubsetsOfSet(int[] set)
        {
            List<List<int>> powerSet = new List<List<int>>();
            List<int> temp = new List<int>();

            Util(powerSet, temp, set, 0);
            PrintPowerSet(powerSet);
        }

        private void Util(List<List<int>> powerSet, List<int> temp, int[] set, int start)
        {
            powerSet.Add(new List<int>(temp));
            for (int i = start; i < set.Length; i++)
            {
                temp.Add(set[i]);
                Util(powerSet, temp, set, i + 1);
                temp.RemoveAt(temp.Count - 1);
            }
        }

        private void PrintPowerSet(List<List<int>> powerSet)
        {
            for (int i = 0; i < powerSet.Count; i++)
            {
                Console.WriteLine("[{0}]", string.Join(", ", powerSet[i]));
            }
        }
    }
}
