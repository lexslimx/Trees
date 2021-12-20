using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class MaximumPathSum
    {
        private int max = int.MinValue;
        public int MaxPathSum(TreeNode root)
        {
            PathSum(root);
            return max;
        }

        private int PathSum(TreeNode node)
        {
            if (node == null) return 0;
            int leftSum = Math.Max(0, PathSum(node.Left));
            int rightSum = Math.Max(0, PathSum(node.Right));
            int currentSum = node.val + leftSum + rightSum;
            max = Math.Max(max, currentSum);

            return Math.Max(leftSum, rightSum) + node.val;
        }
    }
}
