using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieProblems
{
    public class TrieNode
    {
        public TrieNode[] Children;
        public TrieNode()
        {
            Children = new TrieNode[2];
        }
    }
}
