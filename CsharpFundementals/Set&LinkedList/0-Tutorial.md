# Set and Linked List Tutorial

## Introduction
This tutorial introduces two common data structures: **Set** and **Linked List**. You will learn how they work, how to use them in C#, and what makes them useful for different programming tasks. Sets are collections that automatically avoid duplicates, and linked lists are flexible lists where items are connected through node references.

---

## What is a Set?
A Set is a collection that does not allow duplicate elements. It is useful for storing unique data, such as tracking which tasks have already been completed or visited.

### Common Set Operations:
- `Add(item)`: Adds an item if it's not already in the set.
- `Remove(item)`: Removes an item if it exists.
- `Contains(item)`: Checks if the item is in the set.
- `Count`: Gets the number of unique elements.

### Example:
```csharp
HashSet<string> completedTasks = new HashSet<string>();
completedTasks.Add("Wash dishes");
completedTasks.Add("Take out trash");
completedTasks.Add("Wash dishes"); // Won't be added again

Console.WriteLine(completedTasks.Count); // Output: 2
```

---

## What is a Linked List?
A Linked List is a sequence of nodes, where each node contains data and a reference to the next node. This makes it easy to add or remove items without shifting the entire list, unlike arrays.

### Types:
- **Singly Linked List**: Each node links to the next node only.
- **Doubly Linked List**: Nodes link to both the next and previous nodes.

### Common Operations:
- `AddFirst(item)`: Adds to the beginning of the list.
- `AddLast(item)`: Adds to the end.
- `Remove(item)`: Removes the first matching item.
- `Contains(item)`: Checks if item exists.

### Example:
```csharp
LinkedList<string> taskList = new LinkedList<string>();
taskList.AddLast("Finish report");
taskList.AddFirst("Check email");
taskList.AddLast("Attend meeting");

foreach (var task in taskList)
{
    Console.WriteLine(task);
}
```

---

## Summary
Sets and Linked Lists are powerful tools for handling collections. Sets ensure uniqueness and fast lookups, while Linked Lists provide efficient insertions and deletions. By understanding and applying these structures, you can build cleaner and more efficient C# programs.

Use Sets when you need to avoid duplicates. Use Linked Lists when your program often adds or removes items at various positions.

