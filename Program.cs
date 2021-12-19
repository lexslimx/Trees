using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode(5);
            tree.Left = new TreeNode(4);
            tree.Left.Left = new TreeNode(4);
            tree.Left.right = new TreeNode(3);
            tree.right = new TreeNode(3);
            tree.right.Left = new TreeNode(2);
            tree.right.right = new TreeNode(1);

            LeafNodeSum fn = new LeafNodeSum();
            var sum = fn.Sum(tree);
            Console.WriteLine(sum);

            TreeHeight fnh = new TreeHeight();
            var height = fnh.GetHeight(tree);
            Console.WriteLine(height);
        }
    }
}
