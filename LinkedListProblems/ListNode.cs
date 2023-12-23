namespace LinkedListProblems
{
    public class ListNode<T>
    {
        public T Value;
        public ListNode<T>? Next;

        public ListNode(T value)
        {
            Value = value;
            Next = null;
        }
    }
}