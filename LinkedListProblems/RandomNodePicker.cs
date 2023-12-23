namespace LinkedListProblems
{
    public class RandomNodePicker<T>
    {
        private ListNode<T> head;
        private Random random;

        public RandomNodePicker(ListNode<T> listNode)
        {
            head = listNode;
            random = new Random();
        }

        public T GetRandomNode()
        {
            var count = 0;
            ListNode<T>? currentNode = head;

            while (currentNode != null)
            {
                count++;
                currentNode = currentNode.Next;
            }

            int randomIndex = random.Next(count);

            currentNode = head;

            while (randomIndex > 1)
            {
                currentNode = currentNode?.Next;
                randomIndex--;
            }

            return currentNode!.Value;
        }
    }
}
