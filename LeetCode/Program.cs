using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpiralMatrix s = new SpiralMatrix();
            //RotateImage r = new RotateImage();
            //int[][] matrix0 = new int[][]
            //{
            //    new int[] { 01},
            //};
            //int[][] matrix = new int[][]
            //{
            //    new int[] { 01},
            //    new int[] { 02},
            //    new int[] { 03},
            //    new int[] { 04},
            //};
            //int[][] matrix1 = new int[][]
            //{
            //    new int[] { 01, 02 },
            //    new int[] { 04, 03 },
            //};
            //int[][] matrix2 = new int[][]
            //{
            //    new int[] { 01, 02, 03 },
            //    new int[] { 08, 09, 04 },
            //    new int[] { 07, 06, 05 },
            //};
            //int[][] matrix3 = new int[][]
            //{
            //    new int[] { 01, 02, 03, 04 },
            //    new int[] { 10, 11, 12, 05 },
            //    new int[] { 09, 08, 07, 06 },
            //};
            //int[][] matrix4 = new int[][]
            //{
            //    new int[] { 01, 02, 03, 04 },
            //    new int[] { 16, 17, 18, 05 },
            //    new int[] { 15, 24, 19, 06 },
            //    new int[] { 14, 23, 20, 07 },
            //    new int[] { 13, 22, 21, 08 },
            //    new int[] { 12, 11, 10, 09 }
            //};

            //int[][] matrix5 = new int[][]
            //{
            //    new int[] { 01, 02, 03 },
            //    new int[] { 04, 05, 06 },
            //    new int[] { 07, 08, 09 },
            //};

            //int[][] matrix6 = new int[][]
            //{
            //    new int[] { 01, 02, 03, 04 },
            //    new int[] { 05, 06, 07, 08 },
            //    new int[] { 09, 10, 11, 12 },
            //    new int[] { 13, 14, 15, 16 },
            //};

            //int[][] matrix7 = new int[][]
            //{
            //    new int[] { 02, 29, 20, 26, 16, 28 },
            //    new int[] { 12, 27, 09, 25, 13, 21 },
            //    new int[] { 32, 33, 32, 02, 28, 14 },
            //    new int[] { 13, 14, 32, 27, 22, 26 },
            //    new int[] { 33, 01, 20, 07, 21, 07 },
            //    new int[] { 04, 24, 01, 06, 32, 34 },
            //};

            ////r.Rotate(matrix0);
            ////IList<int> spiral = s.SpiralOrder(matrix6);
            ////Console.WriteLine("[{0}]", string.Join(", ", spiral));

            //char[][] board = new char[][]
            //{
            //    new char[] { 'A', 'B', 'C', 'E' },
            //    new char[] { 'S', 'F', 'E', 'S' },
            //    new char[] { 'A', 'D', 'E', 'E' }
            //};
            //char[][] board1 = new char[][]
            //{
            //    new char[] { 'A', 'B' },
            //};

            //WordSearch s = new WordSearch();
            //if(s.Exist(board, "ABCESEEEFS"))
            //    Console.WriteLine("Found!");
            //else
            //    Console.WriteLine("Not Found!");

            //ListNode l1 = new ListNode(1);
            //l1.next = new ListNode(4);
            //l1.next.next = new ListNode(5);

            //ListNode l2 = new ListNode(1);
            //l2.next = new ListNode(3);
            //l2.next.next = new ListNode(4);

            //ListNode l3 = new ListNode(2);
            //l3.next = new ListNode(6);

            //ListNode[] lists = new ListNode[3];
            //lists[0] = l1;
            //lists[1] = l2;
            //lists[2] = l3;

            //MergeKSortedLists m = new MergeKSortedLists();
            //ListNode output = m.MergeKLists(lists);

            //while (output != null)
            //{
            //    Console.Write(output.val + " ");
            //    output = output.next;
            //}
            //Console.WriteLine();
            //Console.WriteLine("Finished Program");


            //TopKFrequent t = new TopKFrequent();
            //int[] output = t.TopKFrequent1(new int[] { 1, 1, 1, 2, 2, 3 }, 2);
            //Console.WriteLine("[{0}]", string.Join(", ", output));

            BTMaxPathSum bt = new BTMaxPathSum();
            //TreeNode n1 = new TreeNode(-1);
            //n1.left = new TreeNode(5);
            //n1.left.left = new TreeNode(4);
            //n1.left.left.right = new TreeNode(2);
            //n1.left.left.right.left = new TreeNode(-4);

            //TreeNode n1 = new TreeNode(5);
            //n1.left = new TreeNode(4);
            //n1.left.left = new TreeNode(11);
            //n1.left.left.left = new TreeNode(7);
            //n1.left.left.right = new TreeNode(2);

            //n1.right = new TreeNode(8);
            //n1.right.left = new TreeNode(13);
            //n1.right.right = new TreeNode(4);
            //n1.right.right.right = new TreeNode(1);

            //int max = bt.MaxPathSum(n1);

            //Console.WriteLine("Max = {0}", max);

            //PriorityQueue pq = new PriorityQueue();
            //pq.Add(10);
            //pq.Add(13);
            //pq.Add(3);
            //pq.Add(5);
            //pq.Add(23);



            //Trie trie = new Trie();
            //trie.Insert("app");
            //trie.Insert("apple");
            //trie.Insert("beer");
            //trie.Insert("add");
            //trie.Insert("jam");
            //trie.Insert("rental");
            //Console.WriteLine(trie.Search("apps")); 
            //Console.WriteLine(trie.Search("app")); 
            //Console.WriteLine(trie.Search("ad"));
            //Console.WriteLine(trie.Search("app"));     // returns false
            //Console.WriteLine(trie.StartsWith("app"));     // returns true
            //trie.Insert("app");
            //Console.WriteLine(trie.Search("app"));     // returns true


            //LongestSubstring ls = new LongestSubstring();
            ////ls.LengthOfLongestSubstring("abcabcbb");
            //ls.LengthOfLongestSubstring("pwwkew");
            //ls.LengthOfLongestSubstring("The quick brown fox jumped over a lazy dog.");
            ////ls.LengthOfLongestSubstring("artistanb");
            ///

            //CombinationSum cs = new CombinationSum();
            //int[] candidates = new int[] {2, 3, 6, 7 };
            //IList<IList<int>> res = cs.GetCombinationSum(candidates, 7);

            //for(int i = 0; i <= res.Count - 1; i++)
            //    Console.WriteLine("[{0}]", string.Join(", ", res[i]));

            //Sort s = new Sort();
            //int[] arr = new int[] { 5, 2, 3, 1 };
            //s.SortArray(arr);
            //Console.WriteLine("[{0}]", string.Join(", ", arr));

            string[] words1 = new string[] { "the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is" };
            string[] words2 = new string[] { "i", "love", "leetcode", "i", "love", "coding" };
            TopKFrequentWords tkfw = new TopKFrequentWords();
            IList<string> topKWords = tkfw.TopKFrequent(words2, 2);
            Console.WriteLine("[{0}]", string.Join(", ", topKWords));
        }
    }
}
