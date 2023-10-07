namespace DequeLibrary.Tests;

[TestFixture]
public class DequeCopyToTests
{
    [Test]
    public void CopyTo_ArrayIsNull_ThrowArgumentNullException()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });

        Assert.Throws<ArgumentNullException>(() => deque.CopyTo(null));
    }

    [Test]
    public void CopyTo_IndexIsNegative_ThrowArgumentOutOfRangeException()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });
        var array = new string[5];

        Assert.Throws<ArgumentOutOfRangeException>(() => deque.CopyTo(array, -1));
    }

    [Test]
    public void CopyTo_IndexIsOutOfArrayBounds_ThrowArgumentOutOfRangeException()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });
        var array = new string[5];

        Assert.Throws<ArgumentOutOfRangeException>(() => deque.CopyTo(array, 5));
    }

    [Test]
    public void CopyTo_DequeSizeBiggerThanAvailableSpaceInArray_ThrowArgumentException()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });
        var array = new string[5];

        Assert.Throws<ArgumentException>(() => deque.CopyTo(array, 3));
    }

    [Test]
    public void CopyTo_CopiesItemsCorrectly()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });
        var array = new string[5];

        deque.CopyTo(array, 1);

        Assert.That(array[0], Is.EqualTo(default));
        Assert.That(array[1], Is.EqualTo("abc"));
        Assert.That(array[2], Is.EqualTo("def"));
        Assert.That(array[3], Is.EqualTo("ghi"));
        Assert.That(array[4], Is.EqualTo(default));
    }
}
