namespace LQueueApp;

public class LQueue<T>
{
    // Internal list that stores the elements in the queue
    private List<T> _queueData;

    public LQueue()
    {
        // Initializes the queue with an empty list
        _queueData = new List<T>();
    }
    
    /// <summary>
    /// Gets the current number of elements in the queue.
    /// </summary>
    public int Size => _queueData.Count;
    
    /// <summary>
    /// Gets the total capacity before resizing occurs.
    /// </summary>
    public int Capacity => _queueData.Capacity;
    
    /// <summary>
    /// Enqueue the value provided into the _queueData
    /// </summary>
    /// <param name="value">The value to add (can be of any type: int, string, etc.)</param>
    public void Enqueue(T value) {
        _queueData.Add(value);
    }
    
    /// <summary>
    /// Dequeue the next value and return it
    /// </summary>
    /// <exception cref="InvalidOperationException">If queue is empty</exception>
    /// <returns>First value in the _queueData</returns>
    public T Dequeue() {
        if (_queueData.Count <= 0)
            throw new InvalidOperationException();

        T value = _queueData[0];
        _queueData.RemoveAt(0);
        return value;
    }

    /// <summary>
    /// Used to retrieve the head of the _queueData without removing it
    /// </summary>
    /// <exception cref="InvalidOperationException">If queue is empty</exception>
    /// <returns>Returns the value at the front of the queue without removing it</returns>
    public T Peek()
    {
        if (_queueData.Count <= 0)
            throw new InvalidOperationException();
        return _queueData[0];
    }

    /// <summary>
    /// Determines whether the queue contains a specific value.
    /// </summary>
    /// <param name="value">The value to locate in the queue.</param>
   /// <returns>Returns true if this queue contains the specified element</returns>
    
    public bool Contains(T value)
    {
        return _queueData.Contains(value);
    }
    
}
