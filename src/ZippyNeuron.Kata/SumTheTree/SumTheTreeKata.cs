namespace ZippyNeuron.Kata.SumTheTree;
public class Node
{
    public int Value;
    public Node Left;
    public Node Right;

    public Node(int value, Node left = null, Node right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

public class SumTheTreeKata
{
    public static int SumTree(Node root) =>
        (root != null ? root.Value + SumTree(root!.Left) + SumTree(root!.Right) : 0);
}
