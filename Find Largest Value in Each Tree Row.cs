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
    public IList<int> LargestValues(TreeNode root) {
        IList<int> levelsMax = new List<int>();
        updateLargest(root, levelsMax, 0);
        return levelsMax;
    }
        public void updateLargest(TreeNode node, IList<int> levelsMax, int level )
        {
            if(node == null)
               return;
            
            if(level > levelsMax.Count-1)
               levelsMax.Add(node.val);
            else 
            {
               if (node.val > levelsMax[level])
                   levelsMax[level] = node.val; 
            }
            updateLargest(node.right, levelsMax, level+1 );
            updateLargest(node.left, levelsMax, level+1);
        }
}
