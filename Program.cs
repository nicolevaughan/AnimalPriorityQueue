namespace AnimalPriorityQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create the queue
            // The data items are strings. The second type parameter (an int) indicates the priority
            PriorityQueue<string, int> animals = new PriorityQueue<string, int>();

            // Add messages with different priorities to the queue
            animals.Enqueue("Penguin", 1);
            animals.Enqueue("Ostrich", 5);
            animals.Enqueue("Puffin", 2);
            animals.Enqueue("Emu", 3);
            animals.Enqueue("Parrot", 4);

            //Count items in the queue
            Console.WriteLine($"There are {animals.Count} animals in the queue");

            // Retrieve the messages in priority and queue order
            while (animals.TryDequeue(out string item, out int priority))
            {
                Console.WriteLine($"Dequeued Item : {item} Priority Was : {priority}");
            }
        }
    }
}