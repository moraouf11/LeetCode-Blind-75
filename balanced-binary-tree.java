/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    public boolean isBalanced(TreeNode root) {
        if(root == null)
            return true;
        int rightH = 1;
        int leftH = 1;

            rightH = treeHeight(root.right );
            leftH = treeHeight(root.left );

        if (Math.abs(rightH-leftH) >1 || !isBalanced(root.left) || !isBalanced(root.right)) 
            return false;
        return true;
    }
    public int treeHeight(TreeNode root){
        if(root== null)
            return 0;

           return 1+ Math.max(treeHeight(root.right),
                             treeHeight(root.left));
        
    }

}
