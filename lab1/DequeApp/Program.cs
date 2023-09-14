using DequeLibrary;

namespace DequeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var deque = new Deque<int>();
            deque.CollectionCleared += () => Console.WriteLine("Collection cleared");
            deque.ElementAdded += item => Console.WriteLine($"Element {item} added");
            deque.ElementRemoved += item => Console.WriteLine($"Element {item} removed");
            
            deque.AddFirst(1);
            deque.AddFirst(2);
            deque.AddLast(3);
            deque.AddLast(4);

            foreach (var item in deque)
            {
                Console.WriteLine(item);
            }

            try
            {
                deque.RemoveFirst();
                deque.RemoveLast();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            foreach (var item in deque)
            {
                Console.WriteLine(item);
            }

            deque.Clear();
        }
    }
}
