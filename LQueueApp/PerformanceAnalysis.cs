namespace LQueueApp;
using System.Diagnostics;

/*
Performance Analysis Results:

This table shows the time (in ticks) taken by each main operation in LQueue<T> for different queue sizes.

Observations:

- Enqueue: Always very fast, no matter the size. Confirms expected O(1) behavior.
- Dequeue: Gets slower as the queue gets bigger. Confirms O(n) because it has to shift elements.
- Peek: Always very fast (about 1 tick), because it just looks at the first item. Confirms O(1).
- Contains: Gets slower as the queue gets bigger. Confirms O(n) because it has to search through all items.

These results show that the actual times match the expected Big-O performance for each operation.*/

public static class PerformanceAnalysis
{
    public static void Run()
    {
        //Create a new queue object.
        var sizes = new[] { 10, 100, 1_000, 10_000, 100_000 };
        
        Console.WriteLine("{0,20} {1,20} {2,20} {3,20} {4,20}","Size (ticks)", "Enqueue(ticks)", "Dequeue (ticks)", "Peek(ticks)", "Contains(ticks)");
        Console.WriteLine("{0,20} {1,20} {2,20} {3,20} {4,20}","------------" ,"------------","------------","------------","------------");
        foreach (var size in sizes){
            // Scenario 1
            // Scenario: Measure Enqueue time with large number of elements
            // Expected Result: Should complete in reasonable time, expected O(1) amortized
        
            var queueEnq = new LQueue<int>();
            for (int i = 0; i < size; i++) queueEnq.Enqueue(i);
            var sw = Stopwatch.StartNew();
            queueEnq.Enqueue(-1);
            sw.Stop();
            var enqueueTicks = sw.ElapsedTicks;
        
            // Scenario 2
            // Scenario: Measure Dequeue time with large number of elements
            // Expected Result: Upon completion of the shift, O(n) is expected
          
            var queueDequeue = new LQueue<int>();
            for (int i = 0; i < size; i++) queueDequeue.Enqueue(i);
            sw.Restart();
            queueDequeue.Dequeue();
            sw.Stop();
            var dequeueTicks = sw.ElapsedTicks;
        
            // Scenario 3
            // Scenario: Measure Peek time with large number of elements
            // Expected Result: Expected O(1)
            var queuePeek = new LQueue<int>();
            for (int i = 0; i < size; i++) queuePeek.Enqueue(i);
            sw.Restart();
            queuePeek.Peek();
            sw.Stop();
            var peekTicks = sw.ElapsedTicks;
            
            // Test 4
            // Scenario: Measure Contains time on large queue
            // Expected Result: Expected O(n)
         var queueContains = new LQueue<int>();
         for (int i = 0; i < size; i++) queueContains.Enqueue(i);
         sw.Restart();
         queueContains.Contains(size - 1);
         sw.Stop();
         var containsTicks = sw.ElapsedTicks;
         Console.WriteLine("{0,20} {1,20} {2,20} {3,20} {4,20}",size,enqueueTicks,dequeueTicks,peekTicks,containsTicks);
        }
        
    }
    
    
}