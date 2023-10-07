namespace DequeLibrary.Tests;

[TestFixture]
public class DequeConstructorsTests
{
    [Test]
    public void DefaultConstructor_InitializesEmptyDeque()
    {
        var deque = new Deque<string>();

        Assert.That(deque.Count, Is.EqualTo(0));
    }

    [Test]
    public void Constructor_GivenCollectionIsNull_ThrowArgumentNullException()
    {
        Assert.Throws<ArgumentNullException>(() => new Deque<string>(null));
    }

    [Test]
    public void Constructor_WithCollection_InitializesDequeWithCorrectValues()
    {
        var collection = new List<string> { "abc", "def", "ghi" };

        var deque = new Deque<string>(collection);

        Assert.That(deque.Count, Is.EqualTo(3));
        Assert.That(deque.Contains("abc"), Is.True);
        Assert.That(deque.Contains("def"), Is.True);
        Assert.That(deque.Contains("ghi"), Is.True);
    }
}
