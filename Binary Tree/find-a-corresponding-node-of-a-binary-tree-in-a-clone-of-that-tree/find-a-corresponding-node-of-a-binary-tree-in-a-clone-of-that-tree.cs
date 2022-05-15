/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        if (original == null)
        {
            return null;
        }

        if (original.val == cloned.val && original.val == target.val)
        {
            return cloned;
        }

        var leftNode = GetTargetCopy(original.left, cloned.left, target);

        if (leftNode != null)
        {
            return leftNode;
        }

        var rightNode = GetTargetCopy(original.right, cloned.right, target);

        return rightNode;
    }
}
