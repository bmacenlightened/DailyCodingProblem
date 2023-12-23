namespace BinaryTreeProblems
{
    public class BinaryTreeNode<T>
    {
        public T Value;
        public BinaryTreeNode<T>? Right;
        public BinaryTreeNode<T>? Left;
        public BinaryTreeNode(T value)
        {
            Value = value;
        }
    }
}