##  Tree (Binary Search Tree)

### Introduction

A **Binary Search Tree (BST)** helps the task manager show tasks in order by priority or due date. 
Each task is placed in the tree depending on its value, which helps users see what’s most 
important first.

The BST has a main node at the top (the root), and tasks are added to the left or right based on 
their importance. If the priority is higher (lower number), the task goes left. If it’s lower 
(higher number), it goes right. This makes tasks easy to sort and display.

In the code, tasks are added to the BST and shown in order using a method called in-order 
traversal. This lets users see their most urgent tasks first. The tree structure also helps with 
adding, finding, or checking tasks quickly.

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
