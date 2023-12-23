namespace ProbabilityProblems
{
    public class TwoDiceRolls
    {
        private Random _rand;

        public TwoDiceRolls()
        {
            _rand = new Random();
        }

        public void RunTestCases()
        {
            var totalOne = 0;
            var totalTwo = 0;
            for (var i = 0; i < 1000; i++)
            {
                var (j, k) = TestCase();
                totalOne += j;
                totalTwo += k;
            }
            var averageOne = totalOne / 1000;
            var averageTwo = totalTwo / 1000;
            Console.WriteLine($"{ averageOne} { averageTwo}");
        }

        public (int, int) TestCase()
        {
            var first = RollingDiceFiveFollowedBySix();
            var second = RollingDiceFiveFollowedByFive();
            return (first, second);
        }

        public int RollingDiceFiveFollowedBySix()
        {
            var rolls = 0;
            var prevRoll = 0;
            while (true)
            {
                var roll = _rand.Next(1, 7);
                rolls++;
                if (prevRoll == 5 && roll == 6)
                {
                    break;
                }
                prevRoll = roll;
            }
            return rolls;
        }
        public int RollingDiceFiveFollowedByFive()
        {
            var rolls = 0;
            var prevRoll = 0;
            while (true)
            {
                var roll = _rand.Next(1, 7);
                rolls++;
                if (prevRoll == 5 && roll == 5)
                {
                    break;
                }
                prevRoll = roll;
            }
            return rolls;
        }

    }
}