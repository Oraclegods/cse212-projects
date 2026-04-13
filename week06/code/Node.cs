public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value == Data)
    {
        return;
    }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2

        if (value == Data)
    {
        return true;
    }
    else if (value < Data)
    {
        // Search left if there is a child there
        return Left != null && Left.Contains(value);
    }
    else
    {
        // Search right if there is a child there
        return Right != null && Right.Contains(value);
    }

    }

    public int GetHeight()
    {
        // TODO Start Problem 4

        // Get the height of the left and right subtrees
    int leftHeight = Left?.GetHeight() ?? 0;
    int rightHeight = Right?.GetHeight() ?? 0;

    // The height is 1 (the current node) + the maximum height of the subtrees
    return 1 + Math.Max(leftHeight, rightHeight);  // Replace this line with the correct return statement(s)
    }
}