# Task Manager Tutorial

## I. Welcome

### Introduction

Welcome to the Task Manager Data Structures Tutorial!
In this tutorial, you’ll learn how to use five essential data structures: **Stack**, **Queue**, **Set**, **Linked List**, and **Binary Search Tree**. These structures are key to building efficient and feature-rich applications.

By the end of this tutorial, you will:

* Understand how each data structure works
* Know how to implement them in C#
* Be able to solve practical problems using them in a real-world application

### Contact Information

Instructor: Ammon Anderson
Email: [ammonanderson64@gmail.com](mailto:ammonanderson64@gmail.com)

---

## II. Stack & Queue

### Introduction

**Stack** is a Last-In-First-Out (LIFO) structure used to store the history of actions like undoing task status.
**Queue** is a First-In-First-Out (FIFO) structure used to handle task scheduling and display.

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

## III. Set & Linked List

### Introduction

A **Set** is a collection of unique values, ideal for storing task names and preventing duplicates.
A **Linked List** allows for dynamic memory allocation and efficient insertion/removal in task lists.

### Set & Linked List Terminology

* **Add (Set)**: Insert a unique value
* **Contains (Set)**: Check if a value exists
* **Node (List)**: Holds a task and link to the next node
* **Head**: First node in the list

### Code Usage (See `task_manager_set_linkedlist.cs`):

* `HashSet<string>` used for case-insensitive task name validation
* `List<TaskItem>` acts as a linked list for dynamic storage and removal

### Efficiency

| Operation          | Time Complexity                     |
| ------------------ | ----------------------------------- |
| Add/Contains (Set) | O(1) avg, O(n) worst                |
| Add/Remove (List)  | O(1) at end, O(n) for search/remove |

### Example Problem

Prevent duplicate task names using a `HashSet`.

### Problem to Solve

Create a feature that suggests combining tasks if the name already exists.

---

## IV. Tree (Binary Search Tree)

### Introduction

A **Binary Search Tree (BST)** is a hierarchical structure that organizes tasks by due date, allowing for fast retrieval in sorted order.

### Tree Terminology

* **Node**: A task with links to child nodes
* **Root**: The top node of the tree
* **Left/Right Child**: Subtasks with earlier or later due dates
* **InOrder Traversal**: Traverse left-root-right to get sorted tasks

### Code Usage (See `task_manager_tree.cs`):

* Custom `BinarySearchTree` with `Insert`, `Remove`, and `InOrderTraversal`
* Used to sort and display tasks by due date

### Efficiency

| Operation | Average Case | Worst Case (Unbalanced) |
| --------- | ------------ | ----------------------- |
| Insert    | O(log n)     | O(n)                    |
| Search    | O(log n)     | O(n)                    |
| Delete    | O(log n)     | O(n)                    |

### Example Problem

Add and display tasks in ascending order of due dates using BST.

### Problem to Solve

Modify the BST to enforce task dependencies. Prevent a task from being started unless its prerequisites are completed.

---

## V. How to Run the Code

1. **Clone the repository**

```bash
git clone https://github.com/YOUR-USERNAME/task-manager-tutorial.git
```

2. **Navigate into each folder** and run the project using the .NET CLI:

```bash
cd stack
 dotnet run
```

Repeat for `/set` and `/tree`.

3. **Extend the programs** by completing the student problems at the end of each section.

---
