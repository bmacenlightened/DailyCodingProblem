namespace ArrayProblems.Test;

public class FancyIntArrayTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ArrayShouldExist()
    {
        var _sut = new FancyIntArray(new[] { 1, 2, 3, 4, 5 });
        Assert.IsInstanceOf(typeof(int[]), _sut.ArrayData);
    }

    [Test]
    public void ShouldReturnFalseIfOnlyOneItem()
    {
        var _sut = new FancyIntArray(new[] { 1 });

        Assert.False(_sut.IsSum(5));
    }

    [Test]
    public void IfArrayHasTwoNumsThatSumToArgumentShouldReturnTrue()
    {
        var _sut = new FancyIntArray(new[] { 1, 2, 3 });

        Assert.True(_sut.IsSum(3));
    }

    [Test]
    public void ProductOfOthersShouldReturnSameArrayIfOnlyOneEntry()
    {
        var _sut = new FancyIntArray(new[] { 1 });

        Assert.That(_sut.ArrayData, Is.EqualTo(_sut.ProductOfOthers()));
    }

    [Test]
    public void ProductOfOthersShouldReturnAsExpectedWithTwoEntries()
    {
        var _sut = new FancyIntArray(new[] { 1, 2 });

        Assert.That(new int[] {2, 1}, Is.EqualTo(_sut.ProductOfOthers()));
    }

    [Test]
    public void ProductOfOthersShouldReturnAsExpectedWithMoreEntries()
    {
        var _sut = new FancyIntArray(new[] { 1, 2, 3, 4 });

        Assert.That(new int[] { 24, 12, 8, 6 }, Is.EqualTo(_sut.ProductOfOthers()));
    }

    [Test]
    public void MinMaxLowComparisonsShouldReturnSameNumberIfLengthOfOne()
    {
        var _sut = new FancyIntArray(new[] { 1 });

        Assert.That((1, 1), Is.EqualTo(_sut.MinMaxLowComparisons()));
    }
    [Test]
    public void MinMaxLowComparisonsShouldReturnCorrectNumbers()
    {
        var _sut = new FancyIntArray(new[] { 1, 4, 7, 2, 5, 3 });

        Assert.That((1, 7), Is.EqualTo(_sut.MinMaxLowComparisons()));
    }

    [Test]
    public void MaxContiguousSubArrayShouldReturnOnlyComponentIfLengthOne()
    {
        var sut = new FancyIntArray(new[] { 1 });

        Assert.That(sut.MaximumSumContiguousSubArray(), Is.EqualTo(1));
    }

    [Test]
    public void MaxContiguousSubArrayShouldReturnRightNumber()
    {
        var sut = new FancyIntArray(new[] { 34, -50, 42, 14, -5, 86 });

        Assert.That(sut.MaximumSumContiguousSubArray(), Is.EqualTo(137));
    }

    [Test]
    public void OptimumJumpsShouldReturnOptimumJumps()
    {
        var sut = new FancyIntArray(new[] { 6,2,4,0,5,1,1,4,2,9 });
        Assert.That(sut.OptimumJumps(), Is.EqualTo(2));
    }
}