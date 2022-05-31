namespace _226_InvertBinaryTree;
public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return null;

        var tempNode = root.left;
        root.left = root.right;
        root.right = tempNode;

        if (root.left != null)
        {
            InvertTree(root.left);
        }

        if (root.right != null)
        {
            InvertTree(root.right);
        }

        return root;
    }
}
