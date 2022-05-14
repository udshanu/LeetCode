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
    public int RangeSumBST(TreeNode root, int low, int high) {
        if (root == null)
        {
            return 0;
        }

        int nodeValueAccrdingToLogic = (root.val >= low && high >= root.val) ? root.val : 0;

        int leftNodeValueAccordingToLogic = RangeSumBST(root.left, low, high);
        int rightNodeValueAccordingToLogic = RangeSumBST(root.right, low, high);

        int sum = nodeValueAccrdingToLogic + leftNodeValueAccordingToLogic + rightNodeValueAccordingToLogic;

        return sum;
    }
}
