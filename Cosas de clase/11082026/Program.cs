public class Program
{
    public static void Main()
    {
        Queue<string> queue = new Queue<string>();
        Console.WriteLine($"Queue elements: {queue.Count}");
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");
        Console.WriteLine($"Queue elements: {queue.Count}");
        Console.WriteLine(queue.Peek());
        int count = queue.Count;


        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine($"Queue elements: {queue.Count}");
        }
    }
public static string FindInQueue(Queue<string> queue, string value)
{
    string result = null;
    bool foundstring = false;
        while (!foundstring && queue.Count > 0)
        {
            result = (queue.Dequeue());
            foundstring = result.Equals(value);
        }
      
return result;
}

}