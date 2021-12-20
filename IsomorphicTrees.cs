using System.Collections.Generic;

public class IsomorphicTrees{
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p == null && q == null) return true;
        if(p !=null && q == null) return false;
        if(p ==null && q != null) return false;
        
        if(p.val != q.val) return false;
        
        return IsSameTree(p.Left, q.right) && IsSameTree(p.right, q.right);
    }
}