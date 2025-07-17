using System;
using System.Collections.Generic;

class QueueExample
{
    static void Main()
    {
        Queue<string> taskQueue = new Queue<string>();

        taskQueue.Enqueue("Task 1");
        taskQueue.Enqueue("Task 2");
        taskQueue.Enqueue("Task 3");

        while (taskQueue.Count > 0)
        {
            Console.WriteLine("Processing: " + taskQueue.Dequeue());
        }
    }
}

