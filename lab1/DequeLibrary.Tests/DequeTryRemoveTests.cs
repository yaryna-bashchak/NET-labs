namespace DequeLibrary.Tests;

[TestFixture]
public class DequeTryRemoveTests
{
    [Test]
    public void TryRemoveFirst_NotEmptyDeque_ReturnsTrueAndFirstItem()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });

        var result = deque.TryRemoveFirst(out string? first);

        Assert.That(deque.Count, Is.EqualTo(2));
        Assert.That(first, Is.EqualTo("abc"));
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void TryRemoveFirst_OneItemInDeque_ReturnsTrueAndFirstItem()
    {
        var deque = new Deque<string>(new string[] { "abc" });

        var result = deque.TryRemoveFirst(out string? first);

        Assert.That(deque.Count, Is.EqualTo(0));
        Assert.That(first, Is.EqualTo("abc"));
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void TryRemoveFirst_EmptyDeque_ReturnsFalseAndDefaultItem()
    {
        var deque = new Deque<string>();

        var result = deque.TryRemoveFirst(out string? first);

        Assert.That(deque.Count, Is.EqualTo(0));
        Assert.That(first, Is.EqualTo(default));
        Assert.That(result, Is.EqualTo(false));
    }

    [Test]
    public void TryRemoveLast_NotEmptyDeque_ReturnsTrueAndLastItem()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });

        var result = deque.TryRemoveLast(out string? last);

        Assert.That(deque.Count, Is.EqualTo(2));
        Assert.That(last, Is.EqualTo("ghi"));
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void TryRemoveLast_OneItemInDeque_ReturnsTrueAndLastItem()
    {
        var deque = new Deque<string>(new string[] { "abc" });

        var result = deque.TryRemoveLast(out string? last);

        Assert.That(deque.Count, Is.EqualTo(0));
        Assert.That(last, Is.EqualTo("abc"));
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void TryRemoveLast_EmptyDeque_ReturnsFalseAndDefaultItem()
    {
        var deque = new Deque<string>();

        var result = deque.TryRemoveFirst(out string? last);

        Assert.That(deque.Count, Is.EqualTo(0));
        Assert.That(last, Is.EqualTo(default));
        Assert.That(result, Is.EqualTo(false));
    }
}
