namespace ArrayProblems
{
    public class FancyIntArray : FancyArray<int>
    {
        public FancyIntArray(int[] inputArray) : base(inputArray)
        {
        }
        //Problem 1
        public bool? IsSum(int v)
        {
            if (ArrayData.Length <= 1)
            {
                return false;
            }
            var set = new HashSet<int>();

            for (var i = 0; i < ArrayData.Length; i++)
            {
                if (set.Contains(v - ArrayData[i]))
                {
                    return true;
                }
                set.Add(ArrayData[i]);
            }
            return false;
        }

        //Kadane's algorithm
        public int MaximumSumContiguousSubArray()
        {
            var maxHere = 0; 
            var max = 0;

            for (var i = 0; i < ArrayData.Length; i++)
            {
                maxHere = Math.Max(ArrayData[i], maxHere + ArrayData[i]);
                max = Math.Max(max, maxHere);
            }

            return max;
        }

        public (int, int) MinMaxLowComparisons()
        {
            var arrayCopy = ArrayData;
            var min = arrayCopy[0];
            var max = arrayCopy[0];

            for (var i = 1; i < arrayCopy.Length; i+= 2)
            {
                int smaller, bigger;
                if (i == arrayCopy.Length - 1)
                {
                    bigger = arrayCopy[i];
                    smaller = arrayCopy[i];
                }
                else if (arrayCopy[i] < arrayCopy[i + 1])
                {
                    smaller = arrayCopy[i];
                    bigger = arrayCopy[i + 1];
                }
                else
                {
                    smaller = arrayCopy[i+1];
                    bigger = arrayCopy[i];
                }
                max = Math.Max(bigger, max);
                min = Math.Min(smaller, min);
            }
            return (min, max);
        }

        public int OptimumJumps()
        {
            int n = ArrayData.Length;
            int[] jumps = new int[n];

            for (int i = 1; i < n; i++)
            {
                jumps[i] = int.MaxValue;
            }

            jumps[n - 1] = 0;

            for (int j = n - 2; j >= 0; j--)
            {
                int minJump = int.MaxValue;
                for (int k = j + 1; k <= j + ArrayData[j] && k < n; k++)
                {
                    if (jumps[k] != int.MaxValue)
                    {
                        minJump = Math.Min(minJump, jumps[k] + 1);
                    }
                }
                jumps[j] = minJump;
            }

            return jumps[0];
        }

        public object ProductOfOthers()
        {
            if (Array.MaxLength <= 1)
            {
                return ArrayData;
            }

            List<int> prefix = new List<int>();
            List<int> suffix = new List<int>();
            var prefixProduct = 1;
            var suffixProduct = 1;

            for (var i = 0; i < ArrayData.Length; i++)
            {
                prefix.Add(prefixProduct);
                prefixProduct *= ArrayData[i];
            }

            for (var i = ArrayData.Length -1; i >= 0; i--)
            {
                suffix.Insert(0, suffixProduct);
                suffixProduct *= ArrayData[i];
            }

            List<int> result = new List<int>();
            for (var i = 0; i < ArrayData.Length; i++)
            {
                result.Add(prefix[i] * suffix[i]);
            }

            return result;
        }
    }
}
