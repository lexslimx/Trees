public class LowestCommonAncestor
{
    //Of a binary search tree
    public TreeNode LCA(TreeNode root, TreeNode p, TreeNode q)
    {
            if(root == null) return null;
            //if p and q are on different sides return the root
            if(p.val < root.val && q.val > root.val) return root;
            if(p.val > root.val && q.val < root.val) return root;
            if(p.val == root.val || q.val == root.val) return root;
            //if they are less than the root search the left
            if(p.val < root.val && q.val < root.val) return LCA(root.Left, p, q);

            //if they are greater than the root search the right side
            if(p.val > root.val && q.val > root.val) return LCA(root.Right, p, q);

            return root;
    }
    public TreeNode LCABST(TreeNode root, TreeNode p, TreeNode q)
    {
            if(root == null) return null;
            //if p and q are on different sides return the root
            if(p.val < root.val && q.val > root.val) return root;
            if(p.val > root.val && q.val < root.val) return root;
            if(p.val == root.val || q.val == root.val) return root;
            //if they are less than the root search the left
            if(p.val < root.val && q.val < root.val) return LCA(root.Left, p, q);

            //if they are greater than the root search the right side
            if(p.val > root.val && q.val > root.val) return LCA(root.Right, p, q);

            return root;
    }
} 