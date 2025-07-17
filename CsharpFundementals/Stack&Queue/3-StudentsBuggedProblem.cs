using System;
using System.Collections.Generic;

class BuggedStackQueueChallenge
{
    static void Main()
    {
        Stack<string> actionStack = new Stack<string>();
        Stack<string> redoStack = new Stack<string>();
        Queue<string> taskQueue = new Queue<string>();

        // Simulate adding tasks
        taskQueue.Enqueue("Clean room");
        taskQueue.Enqueue("Do homework");
        taskQueue.Enqueue("Write report");

        // Bug 1: Incorrect pop order
        Console.WriteLine("Undoing action: " + redoStack.Pop()); // redoStack is empty!

        // Simulate pushing and popping
        actionStack.Push("Add task A");
        actionStack.Push("Add task B");
        string lastAction = actionStack.Pop();
        Console.WriteLine("Undid: " + lastAction);
        redoStack.Push(lastAction);

        // Bug 2: Queue is skipped
        Console.WriteLine("Processing next task: " + taskQueue.Peek()); // forgot to Dequeue
    }
}
