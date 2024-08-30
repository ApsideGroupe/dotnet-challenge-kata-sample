using katas.sample;

[TestFixture]
public class KataTests
{
    [TestCase(new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
    [TestCase(new[] { 1, 3, 5, 7, 9 }, new[] { 10, 8, 6, 4, 2 }, new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })]
    [TestCase(new[] { 1, 3, 5, 7, 9, 11, 12 }, new[] { 1, 2, 3, 4, 5, 10, 12 }, new[] { 1, 2, 3, 4, 5, 7, 9, 10, 11, 12 })]
    [TestCase(new int[] { }, new int[] { }, new int[] { })]
    [TestCase(new[] { 1, 2, 3 }, new int[] { }, new[] { 1, 2, 3 })]
    [TestCase(new int[] { }, new [] { 1, 2, 3, 4, 5 }, new [] { 1, 2, 3, 4, 5 })]
    [TestCase(new[] { -3, -2, -1, 0 }, new [] { 1, 2, 3, 4 }, new [] { -3, -2, -1, 0, 1, 2, 3, 4 } )]
    public void SampleTest(int[] input1, int[] input2, int[] result)
    {
        // Arrange

        // Act

        var mergedArrays = ArrayKata.MergeArrays(input1, input2);

        //Assert

        Assert.That(mergedArrays.Length, Is.EqualTo(result.Length));
        Assert.That(mergedArrays, Is.EqualTo(result));
    }
}