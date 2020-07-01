using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class BTMaxPathSum
    {
        public int MaxPathSum(TreeNode root)
        {
            Info i = PostOrder(root);
            return i.maxSum;
        }

        private (int, int) PostOrder1(TreeNode root)
        {
            if (root == null)
                return (int.MinValue, int.MinValue);

            (int leftMaxSum, int leftMaxArmSum) = PostOrder1(root.left);
            (int rightMaxSum, int rightMaxArmSum) = PostOrder1(root.right);

            int leftCurrArmSum = root.val + (leftMaxArmSum == int.MinValue ? 0 : leftMaxArmSum);
            int rightCurrArmSum = root.val + (rightMaxArmSum == int.MinValue ? 0 : rightMaxArmSum);

            int maxCurrArmSum = Math.Max(leftCurrArmSum, rightCurrArmSum);

            int leftCurrRightSum = root.val + (leftMaxArmSum == int.MinValue ? 0 : leftMaxArmSum) + (rightMaxArmSum == int.MinValue ? 0 : rightMaxArmSum);

            if (root.left == null && root.right == null)
                return (root.val, root.val);

            int maxSum = Math.Max(Math.Max(root.val, leftCurrRightSum), Math.Max(leftMaxSum, rightMaxSum));
            return (maxSum, maxCurrArmSum);
        }

        private Info PostOrder(TreeNode root)
        {
            if (root == null)
                return new Info(int.MinValue, int.MinValue);

            Info leftInfo = PostOrder(root.left);
            int leftMaxSum = leftInfo.maxSum;
            int leftMaxArmSum = leftInfo.maxCurrArmSum;

            Info rightInfo = PostOrder(root.right);
            int rightMaxSum = rightInfo.maxSum;
            int rightMaxArmSum = rightInfo.maxCurrArmSum;

            int leftCurrArmSum = root.val + (leftMaxArmSum == int.MinValue ? 0 : leftMaxArmSum);
            int rightCurrArmSum = root.val + (rightMaxArmSum == int.MinValue ? 0 : rightMaxArmSum);

            int maxCurrArmSum = Math.Max(root.val, Math.Max(leftCurrArmSum, rightCurrArmSum));

            int leftCurrRightSum = root.val + (leftMaxArmSum == int.MinValue ? 0 : leftMaxArmSum) + (rightMaxArmSum == int.MinValue ? 0 : rightMaxArmSum);

            if (root.left == null && root.right == null)
                return new Info(root.val, root.val);

            //int maxSum = Math.Max(Math.Max(root.val, leftCurrRightSum), Math.Max(leftMaxSum, rightMaxSum));

            int maxSum = Math.Max(root.val, Math.Max(leftMaxSum, Math.Max(rightMaxSum, Math.Max(maxCurrArmSum, leftCurrRightSum))));

            Console.WriteLine("Root Value = {0}, LeftCurrRightSum = {1}, LeftMaxSum = {2}, RightMaxSum = {3}, MaxCurrArmSum = {4}", root.val, leftCurrRightSum, leftMaxSum, rightMaxSum, maxCurrArmSum);
            Console.WriteLine();
            return new Info(maxSum, maxCurrArmSum);
        }
    }

    public class Info
    {
        public int maxSum;
        public int maxCurrArmSum;

        public Info(int maxSum, int maxCurrArmSum)
        {
            this.maxSum = maxSum;
            this.maxCurrArmSum = maxCurrArmSum;
        }
    }
}
