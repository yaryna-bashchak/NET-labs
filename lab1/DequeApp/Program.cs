using DequeLibrary;

namespace DequeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var deque = new Deque<int>();
            
            deque.AddFirst(1);
            deque.AddFirst(2);
            deque.AddLast(3);
            deque.AddLast(4);

            foreach (var item in deque)
            {
                Console.WriteLine(item);
            }

            deque.RemoveFirst();
            deque.RemoveLast();

            foreach (var item in deque)
            {
                Console.WriteLine(item);
            }
        }
    }
}
