using System;
namespace LeetCode
{
    public class SLLNode
    {
        public int val;
        public SLLNode next;
        public SLLNode(int x = 0, SLLNode next = null)
        {
            this.val = x;
            this.next = next;
        }
    }
}
