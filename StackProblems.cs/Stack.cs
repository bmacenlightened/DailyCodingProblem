namespace StackProblems.cs
{
    public class Stack<T>
    {
        private SortedDictionary<double, T> _maxHeap;
        public Stack()
        {
            _maxHeap = new SortedDictionary<double, T>(Comparer<double>.Create((a, b) => -a.CompareTo(b)));
        }

        public void Push(T item)
        {
            double currentTime = DateTime.UtcNow.Ticks;
            _maxHeap[currentTime] = item;
        }

        public T Pop()
        {
            if (_maxHeap.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            var item = _maxHeap.First().Value;
            _maxHeap.Remove(_maxHeap.First().Key);
            return item;
        }
    }
}