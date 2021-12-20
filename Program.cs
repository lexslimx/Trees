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
            tree.Left.Right = new TreeNode(3);
            tree.Right = new TreeNode(3);
            tree.Right.Left = new TreeNode(2);
            tree.Right.Right = new TreeNode(1);

            TreeSerializer treeSerializer = new TreeSerializer();
            var ans =treeSerializer.serialize(tree);

            var desc = treeSerializer.deserialize(ans);

            
            Console.WriteLine(ans);
        }
    }
}
