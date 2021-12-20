using System;
using System.Collections.Generic;

public class TreeSerializer
{
    public string serialize(TreeNode root)
    {
        if (root == null) return "x";
        string left = "," + serialize(root.Left);
        string right = "," + serialize(root.Right);
        return root.val + left + right;
    }

    public TreeNode deserialize(string s)
    {
        Queue<string> queue = new Queue<string>();
        foreach (var item in s.Split(","))
        {
            Console.WriteLine(item);
            queue.Enqueue(item);
        }
        return deserializeHelper(queue);
    }

    private TreeNode deserializeHelper(Queue<string> queue)
    {
        var current = queue.Dequeue();
        if (current == "x") return null;

        var newNode = new TreeNode(int.Parse(current));
        newNode.Left = deserializeHelper(queue);
        newNode.Right = deserializeHelper(queue);

        return newNode;
    }
}