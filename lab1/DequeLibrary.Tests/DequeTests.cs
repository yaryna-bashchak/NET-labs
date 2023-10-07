namespace DequeLibrary.Tests;

[TestFixture]
public class DequeTests
{
    // [Test]
    // public void CollectionBecameEmptyEvent_TriggeredWhenDequeIsEmpty()
    // {
    //     var deque = new Deque<int>();
    //     bool wasEventTriggered = false;

    //     deque.CollectionBecameEmpty += () => { wasEventTriggered = true; };

    //     deque.AddLast(1);
    //     deque.RemoveLast();

    //     Assert.IsTrue(wasEventTriggered);
    // }

    // [Test]
    // public void ElementAddedEvent_TriggeredWhenElementAdded()
    // {
    //     var deque = new Deque<int>();
    //     int addedElement = 0;

    //     deque.ElementAdded += (element) => { addedElement = element; };

    //     deque.AddFirst(1);

    //     Assert.That(addedElement, Is.EqualTo(1));
    // }

    // [Test]
    // public void ElementRemovedEvent_TriggeredWhenElementRemoved()
    // {
    //     var deque = new Deque<int>();
    //     int removedElement = 0;

    //     deque.ElementRemoved += (element) => { removedElement = element; };

    //     deque.AddFirst(1);
    //     deque.RemoveFirst();

    //     Assert.That(removedElement, Is.EqualTo(1));
    // }
}