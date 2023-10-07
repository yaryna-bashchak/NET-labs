namespace DequeLibrary.Tests;

[TestFixture]
public class DequePeekTests
{
    [Test]
    public void PeekFirst_NotEmptyDeque_ReturnsItemFromFront()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });

        var first = deque.PeekFirst();

        Assert.That(deque.Count, Is.EqualTo(3));
        Assert.That(first, Is.EqualTo("abc"));
    }

    [Test]
    public void PeekFirst_EmptyDeque_ThrowExeption()
    {
        var deque = new Deque<string>();

        Assert.Throws<InvalidOperationException>(() => deque.PeekFirst());
    }

    [Test]
    public void PeekLast_NotEmptyDeque_ReturnsItemFromBack()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });

        var last = deque.PeekLast();

        Assert.That(deque.Count, Is.EqualTo(3));
        Assert.That(last, Is.EqualTo("ghi"));
    }

    [Test]
    public void PeekLast_EmptyDeque_ThrowExeption()
    {
        var deque = new Deque<string>();

        Assert.Throws<InvalidOperationException>(() => deque.PeekLast());
    }
}
