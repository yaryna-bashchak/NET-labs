namespace DequeLibrary.Tests;

[TestFixture]
public class DequeTryPeekTests
{
    [Test]
    public void TryPeekFirst_NotEmptyDeque_ReturnsTrueAndFirstItem()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });

        var result = deque.TryPeekFirst(out string? first);

        Assert.That(deque.Count, Is.EqualTo(3));
        Assert.That(first, Is.EqualTo("abc"));
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void TryPeekFirst_EmptyDeque_ReturnsFalseAndDefaultItem()
    {
        var deque = new Deque<string>();

        var result = deque.TryPeekFirst(out string? first);

        Assert.That(deque.Count, Is.EqualTo(0));
        Assert.That(first, Is.EqualTo(default));
        Assert.That(result, Is.EqualTo(false));
    }

    [Test]
    public void TryPeekLast_NotEmptyDeque_ReturnsTrueAndLastItem()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });

        var result = deque.TryPeekLast(out string? last);

        Assert.That(deque.Count, Is.EqualTo(3));
        Assert.That(last, Is.EqualTo("ghi"));
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void TryPeekLast_EmptyDeque_ReturnsFalseAndDefaultItem()
    {
        var deque = new Deque<string>();

        var result = deque.TryPeekLast(out string? last);

        Assert.That(deque.Count, Is.EqualTo(0));
        Assert.That(last, Is.EqualTo(default));
        Assert.That(result, Is.EqualTo(false));
    }
}
