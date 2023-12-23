using TrieProblems;

namespace TrieProblemsTests
{
    public class MaxXORArrayTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var sut = new FindMaxXORArray();

            Assert.That(sut.FindMax(new[] { 3, 10, 5, 25, 2 }), Is.EqualTo(28));
        }
    }
}