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
    public int maxDepth(TreeNode root) {
        
        if(root == null){
            return 0;
        }
        else{
            int maxL = maxDepth(root.left);
            int maxR = maxDepth(root.right);
            
            if (maxL > maxR){
                return maxL+1;
            }
            else {
                return maxR+1;
            }
        }
    }
    
}
