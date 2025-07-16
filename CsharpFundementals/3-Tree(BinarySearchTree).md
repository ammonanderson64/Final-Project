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
