public class LeafNodeSum{
    public int Sum(TreeNode root){
        int total = 0;
        total = GetSum(root, 0);
        return total;
    }
    private int GetSum(TreeNode node, int currentSum){
        if(node == null) return 0;
        if(node.Left == null && node.Right == null) return node.val;
        currentSum += GetSum(node.Left, currentSum);
        currentSum += GetSum(node.Right, currentSum);
        return currentSum;
    }
}