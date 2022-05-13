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
    public int DeepestLeavesSum(TreeNode root) {
        int[] sum = new int[1];

        var max_Level = GetDeepestLevel(root);
        GetSumOfDeepestLevelNodes(root, sum, 1, max_Level);

        return sum[0];
    }
    
    public int GetDeepestLevel(TreeNode root)
    {

        if (root == null)
        {
            return 0;
        }

        var leftLevel = GetDeepestLevel(root.left);
        var rightLevel = GetDeepestLevel(root.right);

        int getmax = Math.Max(leftLevel, rightLevel) + 1;

        return getmax;
    }
    
    public int GetSumOfDeepestLevelNodes(TreeNode root, int[] sum, int currentLevel, int maxLevel)
    {
        if (root == null)
        {
            return 0;
        }

        var leftLevel = GetSumOfDeepestLevelNodes(root.left, sum, currentLevel + 1, maxLevel);
        var rightLevel = GetSumOfDeepestLevelNodes(root.right, sum, currentLevel + 1, maxLevel);

        if (leftLevel == maxLevel)
        {
            sum[0] += root.left.val;
        }
        
        if (rightLevel == maxLevel)
        {
            sum[0] += root.right.val;
        }

        return currentLevel;
    }
}
