public class TreeNode
{
    public int Value;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

public class BinarySearchTree
{
    public TreeNode Root;

    public void Insert(int value)
    {
        Root = Insert(Root, value);
    }

    private TreeNode Insert(TreeNode node, int value)
    {
        if (node == null)
            return new TreeNode(value);

        if (value < node.Value)
            node.Left = Insert(node.Left, value);
        else if (value > node.Value)
            node.Right = Insert(node.Right, value);

        return node;
    }

    public bool Search(int value)
    {
        return Search(Root, value);
    }

    private bool Search(TreeNode node, int value)
    {
        if (node == null) return false;
        if (node.Value == value) return true;
        return value < node.Value
            ? Search(node.Left, value)
            : Search(node.Right, value);
    }

    public void InOrderTraversal(TreeNode node)
    {
        if (node == null) return;
        InOrderTraversal(node.Left);
        Console.WriteLine(node.Value);
        InOrderTraversal(node.Right);
    }
}
