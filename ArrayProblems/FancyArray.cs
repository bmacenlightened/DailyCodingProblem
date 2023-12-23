namespace ArrayProblems
{
    public class FancyArray<T>
    {
        public T[] ArrayData;
        public int LengthOfArray;

        public FancyArray(T[] inputArray)
        {
            ArrayData = inputArray;
            LengthOfArray = ArrayData.Length;
        }

    }
}
