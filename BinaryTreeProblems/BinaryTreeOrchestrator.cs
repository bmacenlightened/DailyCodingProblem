using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeProblems
{
    public class BinaryTreeOrchestrator
    {
        public int MinPathSum(BinaryTreeNode<int>? node)
        {
            if (node == null)
            {
                return 0;
            }
            if (node.Left == null && node.Right == null)
            {
                return node.Value;
            }

            var leftSum = MinPathSum(node.Left);
            var rightSum = MinPathSum(node.Right);

            return node.Value + Math.Min(leftSum, rightSum);
        }
    }
}
