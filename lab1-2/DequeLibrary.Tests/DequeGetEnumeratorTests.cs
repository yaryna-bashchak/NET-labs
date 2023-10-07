using System.Collections;

namespace DequeLibrary.Tests;

[TestFixture]
public class DequeGetEnumeratorTests
{
    [Test]
    public void GetEnumerator_EmptyDeque_YieldsNoResult()
    {
        var deque = new Deque<string>();

        var result = deque.ToList();

        Assert.That(result, Is.Empty);
    }

    [Test]
    public void GetEnumerator_NotEmptyDeque_YieldsCorrectResult()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });

        var result = deque.ToList();

        var expected = new List<string> { "abc", "def", "ghi" };
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void NonGenericGetEnumerator_NotEmptyDeque_YieldsCorrectResult()
    {
        var deque = new Deque<string>(new string[] { "abc", "def", "ghi" });

        var result = new List<string>();
        foreach (var item in (IEnumerable)deque)
        {
            result.Add((string)item);
        }

        var expected = new List<string> { "abc", "def", "ghi" };
        Assert.That(result, Is.EqualTo(expected));
    }
}
