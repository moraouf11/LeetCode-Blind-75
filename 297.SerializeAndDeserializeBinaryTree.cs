/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Codec {

    StringBuilder result = new StringBuilder();
    TreeNode treeResult = new TreeNode();
    // Encodes a tree to a single string.
    public string serialize(TreeNode root) 
    {
        buildString(root);
        return result.ToString();
    }

    public void buildString(TreeNode root) {
        if(root == null)
        {
           result.Append("X"+" ");
           return ;
        }
        result.Append(root.val+ " ");

        buildString(root.left);
        buildString(root.right);
    }


    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        string[] dataValues = data.Split(" ");
        Queue<string> queue = new(dataValues);
        return buildTree(queue);
    }

    public TreeNode buildTree(Queue<string> queue) {
        string value = queue.Dequeue();

        if(value == "X")
           return null;

        TreeNode node = new TreeNode(int.Parse(value));
        node.left = buildTree(queue);
        node.right = buildTree(queue);
        return node;  

    }
}

// Your Codec object will be instantiated and called as such:
// Codec ser = new Codec();
// Codec deser = new Codec();
// TreeNode ans = deser.deserialize(ser.serialize(root));
