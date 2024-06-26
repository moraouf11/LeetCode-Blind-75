/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
//  */
// Given a binary tree, find the lowest common ancestor (LCA) of two given nodes in the tree.

// According to the definition of LCA on Wikipedia: “The lowest common ancestor is defined between two nodes 
//     p and q as the lowest node in T that has both p and q as descendants (where we allow a node to be a descendant of itself).”
// Input: root = [6,2,8,0,4,7,9,null,null,3,5], p = 2, q = 8
// Output: 6
// Explanation: The LCA of nodes 2 and 8 is 6.

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root.val == p.val || root.val == q.val)
           return root;
        if(root.val > p.val && root.val < q.val )
           return root;

        if(root.val < p.val && root.val < q.val)
            return LowestCommonAncestor(root.right, p,q);

        if(root.val > p.val && root.val > q.val)
            return LowestCommonAncestor(root.left, p,q);
        
        return root;
    }
}
