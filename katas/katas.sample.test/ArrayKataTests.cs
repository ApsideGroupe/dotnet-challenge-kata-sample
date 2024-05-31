using katas.sample;

[TestFixture]
public class KataTests
{
    [Test]
    public void SampleTest()
    {
        Assert.AreEqual(new[] { 1, 2, 3, 4, 5, 6, 7, 8 }, ArrayKata.MergeArrays(new[] { 1, 2, 3, 4 }, new[] { 5, 6, 7, 8 }));

        Assert.AreEqual(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, ArrayKata.MergeArrays(new[] { 1, 3, 5, 7, 9 }, new[] { 10, 8, 6, 4, 2 }));

        Assert.AreEqual(new[] { 1, 2, 3, 4, 5, 7, 9, 10, 11, 12 }, ArrayKata.MergeArrays(new[] { 1, 3, 5, 7, 9, 11, 12 }, new[] { 1, 2, 3, 4, 5, 10, 12 }));

        Assert.AreEqual(new int[] { }, ArrayKata.MergeArrays(new int[] { }, new int[] { }));

        Assert.AreEqual(new[] { 1, 2, 3 }, ArrayKata.MergeArrays(new[] { 1, 2, 3 }, new int[] { }));

        Assert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, ArrayKata.MergeArrays(new int[] { }, new int[] { 1, 2, 3, 4, 5 }));

        Assert.AreEqual(new int[] { -3, -2, -1, 0, 1, 2, 3, 4 }, ArrayKata.MergeArrays(new[] { -3, -2, -1, 0 }, new int[] { 1, 2, 3, 4 }));
    }
}