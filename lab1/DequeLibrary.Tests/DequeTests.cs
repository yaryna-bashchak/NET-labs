using DequeLibrary;

namespace DequeLibrary.Tests;

[TestFixture]
public class DequeTests
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

        Assert.Throws<InvalidOperationException>(() => deque.RemoveLast());
    }
}