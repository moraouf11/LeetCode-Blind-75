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
    public TreeNode invertTree(TreeNode root) {
            TreeNode temp = null;

        if(root != null){
            if(root.left !=null ){
                temp = invertTree(root.left);
                temp = root.left;      
            }
            if(root.right !=null){
                root.left = invertTree(root.right);
                root.left = root.right;
                root.right = temp;
            }
            else if(root.left !=null){
                root.right = temp;
                root.left = null;
            }
            

        }

        return root;
    }
}
