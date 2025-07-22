// StackQueueFixedChallenge.cs
using System;
using System.Collections.Generic;

class StackQueueFixedChallenge
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

        // Fixed: Check if redoStack has items before popping
        if (redoStack.Count > 0)
        {
            Console.WriteLine("Undoing action: " + redoStack.Pop());
        }
        else
        {
            Console.WriteLine("No actions to redo.");
        }

        // Simulate pushing and popping
        actionStack.Push("Add task A");
        actionStack.Push("Add task B");
        string lastAction = actionStack.Pop();
        Console.WriteLine("Undid: " + lastAction);
        redoStack.Push(lastAction);

        // Fixed: Properly dequeue the task after peeking
        if (taskQueue.Count > 0)
        {
            Console.WriteLine("Processing next task: " + taskQueue.Peek());
            taskQueue.Dequeue();
        }
        else
        {
            Console.WriteLine("No tasks to process.");
        }
    }
}

