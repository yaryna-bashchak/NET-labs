using DequeLibrary;

namespace DequeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var deque = new Deque<string>(new string[] {"world,", "I"});

            deque.CollectionCleared += () => Console.WriteLine("Collection cleared");
            deque.ElementAdded += item => Console.WriteLine($"Element \"{item}\" added");
            deque.ElementRemoved += item => Console.WriteLine($"Element \"{item}\" removed");
            deque.CollectionBecameEmpty += () => Console.WriteLine("Collection became empty");
            deque.CollectionCopied += () => Console.WriteLine("Collection was copied");

            deque.AddLast("am");
            deque.AddLast("deque!");
            deque.AddFirst("Hello");

            deque.Print();

            try
            {
                deque.RemoveFirst();
                deque.RemoveLast();
                Console.WriteLine($"First element: {deque.PeekFirst()}");
                Console.WriteLine($"Last element: {deque.PeekLast()}");

                var array = new string[6];
                deque.CopyTo(array, 2);
                deque.CopyTo(array, 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            deque.Clear();

            try
            {
                deque.RemoveLast();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            deque.AddFirst("Bye");
            deque.RemoveLast();
        }
    }
}
