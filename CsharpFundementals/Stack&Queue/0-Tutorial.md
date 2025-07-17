# Stack and Queue Tutorial (C#)

## What Are Stacks and Queues?

### Stack (LIFO - Last In, First Out)

A **stack** is a collection where the last item added is the first to be removed. Think of it like a stack of plates—you take the top plate off first. In C#, stacks use methods like `.Push()` to add items and `.Pop()` to remove them. `.Peek()` lets you look at the top item without removing it.

### Queue (FIFO - First In, First Out)

A **queue** is a collection where the first item added is the first to be removed. It works like a line at the grocery store. In C#, queues use `.Enqueue()` to add items and `.Dequeue()` to remove them. `.Peek()` lets you check the next item to be removed without actually removing it.

---

## Stack Example

The following code shows how a stack stores user actions that can be undone in reverse order:

```csharp
Stack<string> actions = new Stack<string>();

actions.Push("Added Task 1");
actions.Push("Completed Task 1");

Console.WriteLine("Last Action: " + actions.Peek());     // Completed Task 1
Console.WriteLine("Undoing: " + actions.Pop());          // Completed Task 1
Console.WriteLine("Now Last Action: " + actions.Peek()); // Added Task 1
```

### Key Concepts

- `.Push()` adds an item to the top of the stack.
- `.Pop()` removes and returns the top item.
- `.Peek()` looks at the top item without removing it.

---

## Queue Example

The following example shows how to process tasks in the order they were added:

```csharp
Queue<string> taskQueue = new Queue<string>();

taskQueue.Enqueue("Task 1");
taskQueue.Enqueue("Task 2");
taskQueue.Enqueue("Task 3");

while (taskQueue.Count > 0)
{
    Console.WriteLine("Processing: " + taskQueue.Dequeue());
}
```

### Key Concepts

- `.Enqueue()` adds an item to the end of the queue.
- `.Dequeue()` removes and returns the item at the front.
- `.Count` returns the number of items in the queue.

---

## Common Mistakes

1. **Popping from an empty stack**  
   Attempting to call `.Pop()` or `.Peek()` on an empty stack causes an error. Always check `stack.Count > 0` before doing so.

2. **Using `.Peek()` on a queue without `.Dequeue()`**  
   `.Peek()` just looks at the front item; you must use `.Dequeue()` to actually remove it and move forward.

---
