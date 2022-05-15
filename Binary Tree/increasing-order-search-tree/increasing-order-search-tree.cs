/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode previousNode { get; set; }
    
    public TreeNode IncreasingBST(TreeNode root) {
        TreeNode result = new TreeNode();

        previousNode = result;

        inorder(root);

        return result.right;
    }
    
    public void inorder(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        inorder(root.left);

        previousNode.right = root;
        previousNode = root;
        previousNode.left = null;

        inorder(root.right);
    }
}
