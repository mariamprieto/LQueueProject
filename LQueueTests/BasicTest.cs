namespace LQueueTests;
using NUnit.Framework;
using LQueueApp;

public class BasicTest
{
    
    [Test]
    public void TestLQueue1()
    {
        // Test 1
        // Scenario: Enqueue two values and check the size
        // Expected Result: It should display size = 2
        var queue = new LQueue<int>();
        queue.Enqueue(100);
        queue.Enqueue(200);
        Assert.That(queue.Size, Is.EqualTo(2));
        // Defect(s) Found:
    }
    
    [Test]
    public void TestLQueue2()
    {
        // Test 2
        // Scenario: Enqueue two values and check the capacity
        // Expected Result: Capacity should be at least 2
        var queue = new LQueue<string>();
        queue.Enqueue("A");
        queue.Enqueue("B");
        Assert.That(queue.Capacity, Is.GreaterThanOrEqualTo(2));
        // Defect(s) Found:
    }
    
    [Test]
    public void TestLQueue3()
    {
        // Test 3
        // Scenario: Enqueue one value and then Dequeue it.
        // Expected Result: It should display "A"
        var queue = new LQueue<string>();
        queue.Enqueue("A");
        var result = queue.Dequeue();
        Assert.That(result, Is.EqualTo("A"));
        // Defect(s) Found:
    }

    [Test]
    public void TestLQueue4()
    {
        // Test 4
        // Scenario: Enqueue multiple values and then Dequeue all of them
        // Expected Result: It should display 200, then 300, then 400 in that order
        var queue = new LQueue<int>();
        queue.Enqueue(200);
        queue.Enqueue(300);
        queue.Enqueue(400);
        Assert.That(queue.Dequeue(), Is.EqualTo(200));
        Assert.That(queue.Dequeue(), Is.EqualTo(300));
        Assert.That(queue.Dequeue(), Is.EqualTo(400));
        // Defect(s) Found: 
    }

    
    
    [Test]
    public void TestLQueue5()
    {
        // Test 5
        // Scenario: Enqueue values and call Peek
        // Expected Result: It should return the first value without removing it
        var queue = new LQueue<int>();
        queue.Enqueue(200);
        queue.Enqueue(300);
        
        var peekedValue = queue.Peek();
        Assert.That(peekedValue, Is.EqualTo(200));
        Assert.That(queue.Size, Is.EqualTo(2));
        // Defect(s) Found: 
    }
   
    [Test]
    public void TestLQueue6()
    {
        // Test 6
        // Scenario: Enqueue values and check if Contains finds them
        // Expected Result: Should return true for inserted values and false for others
        var queue = new LQueue<string>();
        queue.Enqueue("apple");
        queue.Enqueue("orange");
        
        
        Assert.That(queue.Contains("apple"), Is.True);
        Assert.That(queue.Contains("orange"), Is.True);
        Assert.That(queue.Contains("cherry"), Is.False);
        // Defect(s) Found: 
    }
}