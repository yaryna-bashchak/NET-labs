namespace DequeLibrary.Tests;

[TestFixture]
public class DequeContainsTests
{
    [Test]
    public void Contains_DequeIsEmpty_ReturnsFalse()
    {
        var deque = new Deque<string>();

        var result = deque.Contains("abc");

        Assert.That(result, Is.False);
    }

    [Test]
    public void Contains_DequeContainsItem_ReturnsTrue()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });

        var result = deque.Contains("def");

        Assert.That(result, Is.True);
    }

    [Test]
    public void Contains_DequeDoesNotContainItem_ReturnsFalse()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });

        var result = deque.Contains("jkl");

        Assert.That(result, Is.False);
    }
}
