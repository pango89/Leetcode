using System;
namespace LeetCode
{
    public class AddTwoNumbersLL
    {
        public SLLNode AddTwoNumbersLLUtil(SLLNode l1, SLLNode l2, int carry)
        {
            if (l1 == null && l2 == null)
            {
                if (carry == 0)
                    return null;
                else
                    return new SLLNode(carry);
            }

            int sum = carry;

            if (l1 != null)
                sum += l1.val;

            if (l2 != null)
                sum += l2.val;

            SLLNode head = new SLLNode(sum % 10);
            SLLNode l1Next = l1?.next;
            SLLNode l2Next = l2?.next;

            head.next = AddTwoNumbersLLUtil(l1Next, l2Next, sum / 10);
            return head;
        }

        public SLLNode AddTwoNumbers(SLLNode l1, SLLNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;
            int carry = 0;
            return AddTwoNumbersLLUtil(l1, l2, carry);
        }
    }
}
