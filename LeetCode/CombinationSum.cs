using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class CombinationSum
    {
        public IList<IList<int>> GetCombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> final = new List<IList<int>>();
            IList<int> current = new List<int>();

            Array.Sort(candidates);
            Util(final, current, candidates, target, 0, candidates.Length - 1);
            //Console.WriteLine("[{0}]", string.Join(", ", final[0]));

            return final;
        }

        public void Util(IList<IList<int>> final, IList<int> current, int[] nums, int target, int start, int end)
        {
            if (target < 0)
                return;

            if (target == 0)
            {
                final.Add(new List<int>(current));
                return;
            }

            for (int i = start; i <= end; i++)
            {
                if (nums[i] <= target)
                {
                    current.Add(nums[i]);
                    Util(final, current, nums, target - nums[i], i, end);
                    current.RemoveAt(current.Count - 1);
                }
            }
        }
    }
}
