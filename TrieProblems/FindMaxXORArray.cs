namespace TrieProblems
{
    public class FindMaxXORArray
    {
        public FindMaxXORArray() 
        {
            
        }

        public int FindMax(int[] array)
        {
            var k = (int)Math.Ceiling(Math.Log(array.Max(), 2));

            Trie trie = new Trie(k);

            foreach (int i in array)
            {
                trie.Insert(i);
            }

            int maxXOR = 0;
            foreach (var i in array)
            {
                maxXOR = Math.Max(maxXOR, trie.FindMaxXOR(i));
            }

            return maxXOR;
        }
    }
}
