using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.

[TestMethod]
// Scenario: Enqueue (A, 2), (B, 5), (C, 3).
// Expected Result: B (Priority 5 is the highest).
// Defect(s) Found:  
// The loop in Dequeue was using index < _queue.Count - 1, which caused it to 
// stop before checking the very last item in the list. Additionally, 
//the item was not actually being removed from the _queue after its value was returned.
public void TestPriorityQueue_HighestInMiddle()
{
    var priorityQueue = new PriorityQueue();
    priorityQueue.Enqueue("A", 2);
    priorityQueue.Enqueue("B", 5);
    priorityQueue.Enqueue("C", 3);

    var result = priorityQueue.Dequeue();
    Assert.AreEqual("B", result);
}



[TestMethod]
// Scenario: Enqueue (A, 5), (B, 2), (C, 5). 
// Expected Result: A (A and C tie at 5, but A was added first).
// Defect(s) Found: 
// The code used the >= operator instead of >. This caused the search 
// to update the highPriorityIndex to the most recent item in a tie, 
// violating the FIFO (First-In, First-Out) requirement for items with equal priority.
public void TestPriorityQueue_TieBreaker()
{
    var priorityQueue = new PriorityQueue();
    priorityQueue.Enqueue("A", 5);
    priorityQueue.Enqueue("B", 2);
    priorityQueue.Enqueue("C", 5);

    var result = priorityQueue.Dequeue();
    Assert.AreEqual("A", result);
}



[TestMethod]
// Scenario: Enqueue (A, 2), (B, 3), (C, 10).
// Expected Result: C (Highest priority is at the very last index).
// Defect(s) Found: 
// The loop was stopping at Count - 1, skipping the last element.
public void TestPriorityQueue_LastItem()
{
    var priorityQueue = new PriorityQueue();
    priorityQueue.Enqueue("A", 2);
    priorityQueue.Enqueue("B", 3);
    priorityQueue.Enqueue("C", 10);

    var result = priorityQueue.Dequeue();
    Assert.AreEqual("C", result);
}



[TestMethod]
// Scenario: Try to Dequeue from an empty queue.
// Expected Result: InvalidOperationException with "The queue is empty."
// Defect(s) Found: 
// If the original code didn't have the if (_queue.Count == 0) check, you would note that it would throw a 
// NullReferenceException or ArgumentOutOfRangeException instead of the 
// required InvalidOperationException with the specific message "The queue is empty."
public void TestPriorityQueue_Empty()
{
    var priorityQueue = new PriorityQueue();

    try
    {
        priorityQueue.Dequeue();
        Assert.Fail("Exception should have been thrown.");
    }
    catch (InvalidOperationException e)
    {
        Assert.AreEqual("The queue is empty.", e.Message);
    }
}

}