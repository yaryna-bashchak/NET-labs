namespace DequeLibrary.Tests;

[TestFixture]
public class DequeClearTests
{
    [Test]
    public void Clear_RemoveAllItems()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });

        deque.Clear();
        var contains = deque.Contains("def");

        Assert.That(deque.Count, Is.EqualTo(0));
        Assert.That(contains, Is.False);
    }

    [Test]
    public void Clear_DequeIsAlreadyEmpty_CountRemainsZero()
    {
        var deque = new Deque<string>();

        deque.Clear();

        Assert.That(deque.Count, Is.EqualTo(0));
    }
}
