using LinkedListProblems;

namespace LinkedListProblemsTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void PairwiseSwitchShouldWorkWithEven()
        {
            var s = new ListNode<int>(1)
            {
                Next = new ListNode<int>(2)
            };
            s.Next.Next = new ListNode<int>(3)
            {
                Next = new ListNode<int>(4)
            };

            var flipped = new PairwiseNodeFlipper().PairwiseFlip(s);
            Assert.Multiple(() =>
            {
                Assert.That(flipped!.Value, Is.EqualTo(2));
                Assert.That(flipped.Next!.Value, Is.EqualTo(1));
                Assert.That(flipped.Next.Next!.Value, Is.EqualTo(4));
                Assert.That(flipped.Next.Next.Next!.Value, Is.EqualTo(3));
            });
        }
    }
}