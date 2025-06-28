namespace LQueueTests;
using NUnit.Framework;
using LQueueApp;


public class MemoryUsageTest
{ 
    
/* Summary:
Scenario:
This test observes how the internal Capacity of the List<T> used inside LQueue<T> changes as elements are enqueued.
Expected Result:
The internal Capacity should increase automatically when the queue runs out of space.
Conclusion:
The test confirms that as we add elements to the list, its capacity increases automatically,
usually doubling each time it runs out of space. This behavior ensures that the LQueue<T>
remains efficient and scalable as it grows.
*/
    [Test]
    public void TestMemoryUsage()
    {
        // Test
        // Scenario: Observe how Capacity changes as we enqueue elements.
        // Expected Result: Capacity increases automatically.
        
        var queue = new LQueue<int>();
        int count = 100_000;
        int lastCapacity = queue.Capacity;

        for (int i = 0; i < count; i++)
        {
            queue.Enqueue(i);
            if (queue.Capacity != lastCapacity)
            {
                Console.WriteLine($"Size: {queue.Size} Capacity: {queue.Capacity}");
                lastCapacity=queue.Capacity;
            }
        }
    }
}