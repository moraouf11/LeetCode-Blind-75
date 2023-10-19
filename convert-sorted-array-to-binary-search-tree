/**
 * Problem Statement :
 * Given an integer array nums where the elements are sorted in ascending order, convert it to a height-balanced binary search tree.
 */



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
    public TreeNode SortedArrayToBST(int[] nums) {
        if(nums.Length ==0)
            return null;

        int mid = (nums.Length -1)/2;

        TreeNode root =  new TreeNode( nums[mid]);

        root.left = SortedArrayToBST(nums[..(mid)]);
        root.right = SortedArrayToBST(nums[(mid+1)..]);

        return root;
    }
}
