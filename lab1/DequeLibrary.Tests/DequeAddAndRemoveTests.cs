namespace DequeLibrary.Tests;

[TestFixture]
public class DequeAddAndRemoveTests
{
    [Test]
    public void AddFirst_EmptyDeque_AddsItemsToFront()
    {
        var deque = new Deque<string>();
        deque.AddFirst("abc");
        deque.AddFirst("def");

        Assert.That(deque.Count, Is.EqualTo(2));
        Assert.That(deque.RemoveFirst(), Is.EqualTo("def"));
        Assert.That(deque.RemoveFirst(), Is.EqualTo("abc"));
    }

    [Test]
    public void AddFirst_NotEmptyDeque_AddsItemsToFront()
    {
        var deque = new Deque<string>(new string[] { "abc", "def" });
        deque.AddFirst("ghi");

        Assert.That(deque.Count, Is.EqualTo(3));
        Assert.That(deque.RemoveFirst(), Is.EqualTo("ghi"));
    }

    [Test]
    public void AddLast_EmptyDeque_AddsItemsToBack()
    {
        var deque = new Deque<string>();
        deque.AddLast("abc");
        deque.AddLast("def");

        Assert.That(deque.Count, Is.EqualTo(2));
        Assert.That(deque.RemoveLast(), Is.EqualTo("def"));
        Assert.That(deque.RemoveLast(), Is.EqualTo("abc"));
    }

    [Test]
    public void AddLast_NotEmptyDeque_AddsItemsToBack()
    {
        var deque = new Deque<string>(new string[] { "abc", "def" });
        deque.AddLast("ghi");

        Assert.That(deque.Count, Is.EqualTo(3));
        Assert.That(deque.RemoveLast(), Is.EqualTo("ghi"));
    }

    [Test]
    public void RemoveFirst_NotEmptyDeque_RemovesItemsFromFront()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });

        var first1 = deque.RemoveFirst();
        var first2 = deque.RemoveFirst();

        Assert.That(deque.Count, Is.EqualTo(1));
        Assert.That(first1, Is.EqualTo("abc"));
        Assert.That(first2, Is.EqualTo("def"));
    }

    [Test]
    public void RemoveFirst_OneItemInDeque_RemovesLastItemInDeque()
    {
        var deque = new Deque<string>(new string[] { "abc" });

        var last = deque.RemoveFirst();

        Assert.That(deque.Count, Is.EqualTo(0));
        Assert.That(last, Is.EqualTo("abc"));
    }

    [Test]
    public void RemoveFirst_EmptyDeque_ThrowExeption()
    {
        var deque = new Deque<string>();

        Assert.Throws<InvalidOperationException>(() => deque.RemoveFirst());
    }

    [Test]
    public void RemoveLast_NotEmptyDeque_RemovesItemsFromBack()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });

        var last1 = deque.RemoveLast();
        var last2 = deque.RemoveLast();

        Assert.That(deque.Count, Is.EqualTo(1));
        Assert.That(last1, Is.EqualTo("ghi"));
        Assert.That(last2, Is.EqualTo("def"));
    }

    [Test]
    public void RemoveLast_OneItemInDeque_RemovesLastItemInDeque()
    {
        var deque = new Deque<string>(new string[] { "abc" });

        var last = deque.RemoveLast();

        Assert.That(deque.Count, Is.EqualTo(0));
        Assert.That(last, Is.EqualTo("abc"));
    }

    [Test]
    public void RemoveLast_EmptyDeque_ThrowExeption()
    {
        var deque = new Deque<string>();

        Assert.Throws<InvalidOperationException>(() => deque.RemoveLast());
    }
}
