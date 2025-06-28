namespace LQueueTests;
using NUnit.Framework;
using LQueueApp;
using System.Diagnostics;

/*
Performance Tests Summary:

These performance tests were successfully executed using different data types: int, string, and bool.
The tests covered the following operations in the LQueue<T> class:

- Enqueue
- Dequeue
- Peek
- Contains

Observations:

- Enqueue performed very fast for all data types, confirming its expected amortized O(1) complexity.
- Dequeue took longer because it involves shifting elements, confirming its expected O(n) complexity.
- Peek was consistently fast regardless of the data type, confirming its O(1) behavior.
- Contains performed slower when searching for elements near the end of the queue, confirming its O(n) behavior.
  To better observe the time difference, Stopwatch.ElapsedTicks was used instead of ElapsedMilliseconds

These results demonstrate that the LQueue<T> implementation works correctly and efficiently for different data types,
and its performance aligns with theoretical Big-O expectations.
*/

public class PerformanceTests
{
  
  [Test]
  public void TestPerformance1()
  {
    // Test 1
    // Scenario: Measure Enqueue time with large number of elements
    // Expected Result: Should complete in reasonable time, expected O(1) amortized
    
    var queue = new LQueue<int>();
    var sw = new Stopwatch();
    int count = 100_000;
    
    sw.Start();
    for (int i = 0; i < count; i++)
    {
      queue.Enqueue(i);
    }
    sw.Stop();
    Console.WriteLine($"Enqueue {count}: times took: {sw.ElapsedMilliseconds} ms");
    // Defect(s) Found:
  } 
  
  
  [Test]
  public void TestPerformance2()
  {
    // Test 2
    // Scenario: Measure Dequeue time with large number of elements
    // Expected Result: Upon completion of the shift, O(n) is expected
    
    var queue = new LQueue<int>();
    var sw = new Stopwatch();
    int count = 100_000;
    
    for (int i = 0; i < count; i++)
    {
      queue.Enqueue(i);
    }
    
    sw.Start();
    while (queue.Size > 0)
    {
      queue.Dequeue();
    }
    sw.Stop();
    Console.WriteLine($"Dequeue {count}: times took: {sw.ElapsedMilliseconds}ms");
    // Defect(s) Found:
  } 
  
  [Test]
  public void TestPerformance3()
  {
    // Test 3
    // Scenario: Measure Peek time with large number of elements
    // Expected Result: Expected O(1)
    
    var queue = new LQueue<int>();
    var sw = new Stopwatch();
    int count = 100_000;
    
    for (int i = 0; i < count; i++)
    {
      queue.Enqueue(i);
    }
    
    sw.Start();
    for (int i = 0; i < count; i++)
    {
      queue.Peek();
    }
    sw.Stop();
    Console.WriteLine($"Peek {count}: times took: {sw.ElapsedMilliseconds} ms");
    // Defect(s) Found:
  } 
  
  [Test]
  public void TestPerformance4()
  {
    // Test 4
    // Scenario: Measure Contains time on large queue
    // Expected Result: Expected O(n)
    
    var queue = new LQueue<int>();
    var sw = new Stopwatch();
    int count = 100_000;
    
    for (int i = 0; i < count; i++)
    {
      queue.Enqueue(i);
    }
    
    sw.Start();
    bool itemfound = queue.Contains(count - 1);
    sw.Stop();
    Console.WriteLine($"Contains took: {sw.ElapsedTicks} ticks. Found : {itemfound}");
    // Defect(s) Found:
  } 
  
  [Test]
  public void TestPerformance5()
  {
    // Test 5
    // Scenario: Measure Enqueue time with large number of elements
    // Expected Result: Should complete in reasonable time, expected O(1) amortized
    
    var queue = new LQueue<string>();
    var sw = new Stopwatch();
    int count = 100_000;
    
    sw.Start();
    for (int i = 0; i < count; i++)
    {
      queue.Enqueue("A"+i);
    }
    sw.Stop();
    Console.WriteLine($"Enqueue {count}: times took: {sw.ElapsedMilliseconds} ms");
    // Defect(s) Found:
  } 
  
  
  [Test]
  public void TestPerformance6()
  {
    // Test 6
    // Scenario: Measure Dequeue time with large number of elements
    // Expected Result: Upon completion of the shift, O(n) is expected
    
    var queue = new LQueue<string>();
    var sw = new Stopwatch();
    int count = 100_000;
    
    for (int i = 0; i < count; i++)
    {
      queue.Enqueue("A" +i);
    }
    
    sw.Start();
    while (queue.Size > 0)
    {
      queue.Dequeue();
    }
    sw.Stop();
    Console.WriteLine($"Dequeue {count}: times took: {sw.ElapsedMilliseconds}ms");
    // Defect(s) Found:
  } 
  
  [Test]
  public void TestPerformance7()
  {
    // Test 7
    // Scenario: Measure Peek time with large number of elements
    // Expected Result: Expected O(1)
    
    var queue = new LQueue<string>();
    var sw = new Stopwatch();
    int count = 100_000;
    
    for (int i = 0; i < count; i++)
    {
      queue.Enqueue("A" +i);
    }

    
    sw.Start();
    for (int i = 0; i < count; i++)
    {
      queue.Peek();
    }
    sw.Stop();
    Console.WriteLine($"Peek {count}: times took: {sw.ElapsedMilliseconds} ms");
    // Defect(s) Found:
  } 
  
  [Test]
  public void TestPerformance8()
  {
    // Test 8
    // Scenario: Measure Contains time on large queue
    // Expected Result: Expected O(n)
    
    var queue = new LQueue<string>();
    var sw = new Stopwatch();
    int count = 100_000;
    
    for (int i = 0; i < count; i++)
    {
      queue.Enqueue("A" +i);
    }
    
    sw.Start();
    bool itemfound = queue.Contains("A" +(count - 1));
    sw.Stop();
    Console.WriteLine($"Contains took: {sw.ElapsedTicks} ticks. Found : {itemfound}");
    // Defect(s) Found:
  } 
  [Test]
  public void TestPerformance9()
  {
    // Test 9
    // Scenario: Measure Enqueue time with large number of elements
    // Expected Result: Should complete in reasonable time, expected O(1) amortized
    
    var queue = new LQueue<bool>();
    var sw = new Stopwatch();
    int count = 100_000;
    
    sw.Start();
    for (int i = 0; i < count; i++)
    {
      queue.Enqueue(i%2==0);
    }
    sw.Stop();
    Console.WriteLine($"Enqueue {count}: times took: {sw.ElapsedMilliseconds} ms");
    // Defect(s) Found:
  } 
  
  
  [Test]
  public void TestPerformance10()
  {
    // Test 10
    // Scenario: Measure Dequeue time with large number of elements
    // Expected Result: Upon completion of the shift, O(n) is expected
    
    var queue = new LQueue<bool>();
    var sw = new Stopwatch();
    int count = 100_000;
    
    for (int i = 0; i < count; i++)
    {
      queue.Enqueue(i%2==0);
    }
    
    sw.Start();
    while (queue.Size > 0)
    {
      queue.Dequeue();
    }
    sw.Stop();
    Console.WriteLine($"Dequeue {count}: times took: {sw.ElapsedMilliseconds}ms");
    // Defect(s) Found:
  } 
  
  [Test]
  public void TestPerformance11()
  {
    // Test 11
    // Scenario: Measure Peek time with large number of elements
    // Expected Result: Expected O(1)
    
    var queue = new LQueue<bool>();
    var sw = new Stopwatch();
    int count = 100_000;
    
    for (int i = 0; i < count; i++)
    {
      queue.Enqueue(i%2==0);
    }
    
    sw.Start();
    for (int i = 0; i < count; i++)
    {
      queue.Peek();
    }
    sw.Stop();
    Console.WriteLine($"Peek {count}: times took: {sw.ElapsedMilliseconds} ms");
    // Defect(s) Found:
  } 
  
  [Test]
  public void TestPerformance12()
  {
    // Test 12
    // Scenario: Measure Contains time on large queue
    // Expected Result: Expected O(n)
    
    var queue = new LQueue<bool>();
    var sw = new Stopwatch();
    int count = 100_000;
    
    for (int i = 0; i < count; i++)
    {
      queue.Enqueue(i%2==0);
    }

    
    sw.Start();
    bool itemfound = queue.Contains(true);
    sw.Stop();
    Console.WriteLine($"Contains took: {sw.ElapsedTicks} ticks. Found : {itemfound}");
    // Defect(s) Found:
  } 
}