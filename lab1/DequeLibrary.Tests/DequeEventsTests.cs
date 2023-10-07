namespace DequeLibrary.Tests;

[TestFixture]
public class DequeEventsTests
{
    [Test]
    public void CollectionBecameEmptyEvent_TriggeredWhenDequeIsEmptyBecauseRemoveFirst()
    {
        var deque = new Deque<string>(new string[] { "abc" });
        bool wasEventTriggered = false;

        deque.CollectionBecameEmpty += () => { wasEventTriggered = true; };

        deque.RemoveFirst();

        Assert.That(wasEventTriggered, Is.True);
    }

    [Test]
    public void CollectionBecameEmptyEvent_TriggeredWhenDequeIsEmptyBecauseRemoveLast()
    {
        var deque = new Deque<string>(new string[] { "abc" });
        bool wasEventTriggered = false;

        deque.CollectionBecameEmpty += () => { wasEventTriggered = true; };

        deque.RemoveLast();

        Assert.That(wasEventTriggered, Is.True);
    }

    [Test]
    public void CollectionBecameEmptyEvent_NotTriggeredWhenDequeIsNotEmptyBecauseRemoveFirst()
    {
        var deque = new Deque<string>(new string[] { "abc", "def" });
        bool wasEventTriggered = false;

        deque.CollectionBecameEmpty += () => { wasEventTriggered = true; };

        deque.RemoveFirst();

        Assert.That(wasEventTriggered, Is.False);
    }

    [Test]
    public void CollectionBecameEmptyEvent_NotTriggeredWhenDequeIsNotEmptyBecauseRemoveLast()
    {
        var deque = new Deque<string>(new string[] { "abc", "def" });
        bool wasEventTriggered = false;

        deque.CollectionBecameEmpty += () => { wasEventTriggered = true; };

        deque.RemoveLast();

        Assert.That(wasEventTriggered, Is.False);
    }

    [Test]
    public void CollectionBecameEmptyEvent_TriggeredWhenDequeIsEmptyBecauseClear()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });
        bool wasEventTriggered = false;

        deque.CollectionBecameEmpty += () => { wasEventTriggered = true; };

        deque.Clear();

        Assert.That(wasEventTriggered, Is.True);
    }

    [Test]
    public void CollectionClearedEvent_TriggeredWhenDequeIsClearedBecauseClear()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });
        bool wasEventTriggered = false;

        deque.CollectionCleared += () => { wasEventTriggered = true; };

        deque.Clear();

        Assert.That(wasEventTriggered, Is.True);
    }

    [Test]
    public void ElementAddedEvent_TriggeredWhenElementAddedBecauseAddFirst()
    {
        var deque = new Deque<string>();
        string? addedElement = default;

        deque.ElementAdded += (element) => { addedElement = element; };

        deque.AddFirst("abc");

        Assert.That(addedElement, Is.EqualTo("abc"));
    }

    [Test]
    public void ElementAddedEvent_TriggeredWhenElementAddedBecauseAddLast()
    {
        var deque = new Deque<string>();
        string? addedElement = default;

        deque.ElementAdded += (element) => { addedElement = element; };

        deque.AddLast("abc");

        Assert.That(addedElement, Is.EqualTo("abc"));
    }

    [Test]
    public void ElementRemovedEvent_TriggeredWhenElementRemovedBecauseRemoveFirst()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });
        string? removedElement = default;

        deque.ElementRemoved += (element) => { removedElement = element; };

        deque.RemoveFirst();

        Assert.That(removedElement, Is.EqualTo("abc"));
    }

    [Test]
    public void ElementRemovedEvent_TriggeredWhenElementRemovedBecauseRemoveLast()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });
        string? removedElement = default;

        deque.ElementRemoved += (element) => { removedElement = element; };

        deque.RemoveLast();

        Assert.That(removedElement, Is.EqualTo("ghi"));
    }


    [Test]
    public void CollectionCopiedEvent_TriggeredWhenDequeIsCopiedBecauseCopyTo()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });
        bool wasEventTriggered = false;

        deque.CollectionCopied += () => { wasEventTriggered = true; };

        deque.CopyTo(new string[5], 2);

        Assert.That(wasEventTriggered, Is.True);
    }
}