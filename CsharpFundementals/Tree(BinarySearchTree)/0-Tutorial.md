# Binary Search Tree (BST) Tutorial

## Introduction
A Binary Search Tree (BST) is a hierarchical data structure made up of nodes, where each node has at most two children: left and right. The left child contains only nodes with values less than the parent, and the right child contains only nodes with values greater than the parent. BSTs are useful for fast searching, insertion, and deletion.

### Common Use Cases
- Storing sorted data for fast lookups
- Implementing dynamic search tables
- Autocomplete or dictionary-style features

---

## Key Terminology
- **Node**: Basic unit of the tree containing a value.
- **Root**: The topmost node.
- **Leaf**: A node with no children.
- **Left/Right Child**: References to other nodes.
- **Subtree**: A tree formed by a node and its descendants.

---

## Basic Operations
| Operation | Average Case | Worst Case |
|-----------|--------------|------------|
| Insert    | O(log n)     | O(n)       |
| Search    | O(log n)     | O(n)       |
| Delete    | O(log n)     | O(n)       |

---

## Summary
Binary Search Trees are efficient for searching, inserting, and deleting sorted data. 
Understanding how BSTs work will help you write faster, more efficient applications when managing 
large datasets.
