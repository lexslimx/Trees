using System;

public class TreeHeight{
    public int GetHeight(TreeNode tree){
        if(tree == null) return -1; //correction since a single node has 0 height

        if(tree.Left == null && tree.Right == null) return 0;

        int left =  GetHeight(tree.Left);
        int right = GetHeight(tree.Right);

        return Math.Max(left, right) + 1;
    }
}