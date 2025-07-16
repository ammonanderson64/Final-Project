## Stack & Queue

### Introduction

Stacks and queues are simple yet powerful tools for organizing data. A **stack** is like a pile of 
dishes — the last dish placed on top is the first one taken off. In this project, the stack helps 
users undo actions like adding or completing a task. Each time something changes, we record it on 
the stack. If the user wants to go back, we just remove the most recent change.

A **queue** is more like a line at a store. The first task added is the first one processed. This 
makes queues great for showing tasks in the order they were created. When users add tasks, they go 
to the back of the line. When tasks are shown or checked off, they’re taken from the front. This 
system keeps things fair and predictable.

In the code, the stack remembers recent actions to support an undo button, while the queue keeps 
tasks lined up in the right order. These two tools work together to give users more control and a 
smoother experience.

### Stack & Queue Terminology

* **Push (Stack)**: Add an item to the top of the stack
* **Pop (Stack)**: Remove the item from the top
* **Enqueue (Queue)**: Add an item to the end of the queue
* **Dequeue (Queue)**: Remove the item at the front

### Code Usage (See `task_manager_stack_queue.cs`):

* Stack is used to track user actions for undo functionality
* Queue is used to store task input in order for display or scheduling

### Efficiency

| Operation               | Time Complexity |
| ----------------------- | --------------- |
| Push/Pop (Stack)        | O(1)            |
| Enqueue/Dequeue (Queue) | O(1)            |

### Example Problem

Simulate a task manager where users can undo adding a task or marking it completed using a **stack**.

### Problem to Solve

Extend the task manager to include **redo functionality** using a second stack.

---
