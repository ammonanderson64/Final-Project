// BinarySearchTreeExample.cs
using System;

class Node
{
    public int Value;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

class BinarySearchTree
{
    public Node Root;

    public void Insert(int value)
    {
        Root = InsertRecursive(Root, value);
    }

    private Node InsertRecursive(Node node, int value)
    {
        if (node == null)
        {
            return new Node(value);
        }

        if (value < node.Value)
        {
            node.Left = InsertRecursive(node.Left, value);
        }
        else if (value > node.Value)
        {
            node.Right = InsertRecursive(node.Right, value);
        }

        return node;
    }

    public bool Search(int value)
    {
        return SearchRecursive(Root, value);
    }

    private bool SearchRecursive(Node node, int value)
    {
        if (node == null) return false;
        if (node.Value == value) return true;
        if (value < node.Value) return SearchRecursive(node.Left, value);
        return SearchRecursive(node.Right, value);
    }

    public void InOrderTraversal()
    {
        InOrderRecursive(Root);
        Console.WriteLine();
    }

    private void InOrderRecursive(Node node)
    {
        if (node != null)
        {
            InOrderRecursive(node.Left);
            Console.Write(node.Value + " ");
            InOrderRecursive(node.Right);
        }
    }

    public void Delete(int value)
    {
        Root = DeleteRecursive(Root, value);
    }

    private Node DeleteRecursive(Node root, int key)
    {
        if (root == null) return root;

        if (key < root.Value)
        {
            root.Left = DeleteRecursive(root.Left, key);
        }
        else if (key > root.Value)
        {
            root.Right = DeleteRecursive(root.Right, key);
        }
        else
        {
            // Node with only one child or no child
            if (root.Left == null)
                return root.Right;
            else if (root.Right == null)
                return root.Left;

            // Node with two children: get inorder successor
            root.Value = MinValue(root.Right);
            root.Right = DeleteRecursive(root.Right, root.Value);
        }

        return root;
    }

    private int MinValue(Node node)
    {
        int minv = node.Value;
        while (node.Left != null)
        {
            minv = node.Left.Value;
            node = node.Left;
        }
        return minv;
    }
}

class Program
{
    static void Main()
    {
        BinarySearchTree bst = new BinarySearchTree();
        int[] values = { 15, 10, 20, 8, 12, 17, 25 };

        foreach (var val in values)
        {
            bst.Insert(val);
        }

        Console.WriteLine("In-order Traversal of BST:");
        bst.InOrderTraversal();

        int searchValue = 12;
        Console.WriteLine($"\nSearching for {searchValue}: " + (bst.Search(searchValue) ? "Found" : "Not Found"));

        Console.WriteLine("\nDeleting value 10 and reprinting tree:");
        bst.Delete(10);
        bst.InOrderTraversal();
    }
}
