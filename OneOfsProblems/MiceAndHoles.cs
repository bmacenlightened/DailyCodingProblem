using System.Collections.Immutable;

namespace OneOfsProblems
{
    public class MiceAndHoles
    {
        private int[] Mice; 
        private int[] Holes;
        public MiceAndHoles(int[] mice, int[] holes)
        {
            Mice = mice;
            Holes = holes;
        }

        public int MinMoves()
        {
            var miceInOrder = Mice.Order().ToArray();
            var holesInOrder = Holes.Order().ToArray();
            var moves = 0;

            for (var i = 0; i < miceInOrder.Length; i++)
            {
                moves = Math.Max(moves, Math.Abs(miceInOrder[i] - holesInOrder[i]));
            }

            return moves;
        }
    }
}