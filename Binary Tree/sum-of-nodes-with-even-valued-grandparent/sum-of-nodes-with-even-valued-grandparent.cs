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
    public static int sum { get; set; }
    
    public int SumEvenGrandparent(TreeNode root) 
    {
        int result = 0;
        sum = result;
        SumEvenGrandparentLogic(root);

        return sum;
    }
    
    public static void SumEvenGrandparentLogic(TreeNode root)
    {
        if (root == null)
        {
            return;
        }

        if (root.left != null && (root.left.left != null || root.left.right != null))
        {
            if (root.val % 2 == 0)
            {
                if (root.left.left != null)
                {
                    sum += root.left.left.val;
                }

                if (root.left.right != null)
                {
                    sum += root.left.right.val;
                }
            }
        }

        if (root.right != null && (root.right.left != null || root.right.right != null))
        {
            if (root.val % 2 == 0)
            {
                if (root.right.left != null)
                {
                    sum += root.right.left.val;
                }

                if (root.right.right != null)
                {
                    sum += root.right.right.val;
                }
            }
        }

        SumEvenGrandparentLogic(root.left);
        SumEvenGrandparentLogic(root.right);
    }
}
