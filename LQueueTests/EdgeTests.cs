namespace LQueueTests;
using NUnit.Framework;
using LQueueApp;

public class EdgeTests
{
    [Test]
    public void EdgeTestLQueue1()
    {
        // Test 1
        // Scenario: Dequeue from an empty Queue
        // Expected Result: An exception should be raised
        var queue = new LQueue<int>();
        try {
            queue.Dequeue();
            Assert.Fail("Oops ... Exception expected.");
        }
        catch (InvalidOperationException) {
            Console.WriteLine("I got the exception as expected.");
        }
        // Defect(s) Found: 
    }
    [Test]
    public void EdgeTestLQueue2()
    {
        // Test 2
        // Scenario: Peek from an empty queue
        // Expected Result: An exception should be raised
        var queue = new LQueue<int>();
        try {
            queue.Peek();
            Assert.Fail("Oops ... Exception expected.");
        }
        catch (InvalidOperationException) {
            Console.WriteLine("I got the exception as expected.");
        }
        // Defect(s) Found: 
    }
    
}