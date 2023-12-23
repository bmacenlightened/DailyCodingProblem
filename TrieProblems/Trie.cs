using System.IO.Compression;

namespace TrieProblems
{
    public class Trie
    {
        private TrieNode root;
        private int size;

        public Trie(int k)
        {
            root = new TrieNode();
            size = k;
        }

        public void Insert(int item)
        {
            TrieNode node = root;

            for (int i = size; i >= 0; i--)
            {
                int bit = (item & (1 << i)) >> i;
                if (node.Children[bit] == null)
                {
                    node.Children[bit] = new TrieNode();
                }
                node = node.Children[bit];
            }
        }

        public int FindMaxXOR(int item)
        {
            TrieNode node = root;
            int maxXOR = 0;

            for (int i = size; i >= 0; i--)
            {
                int bit = (item & (1 << i)) >> i;
                int complement = 1 - bit;
                 if (node.Children[complement] != null)
                {
                    maxXOR |= (1 << i);
                    node = node.Children[complement];
                }
                 else
                {
                    node = node.Children[bit];
                }
            }
            return maxXOR;
        }
    }
}