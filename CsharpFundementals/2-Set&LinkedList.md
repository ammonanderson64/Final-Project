## Set & Linked List

### Introduction

Sets and linked lists help manage task names and storage. A **set** keeps task names unique so 
users don't accidentally create the same task twice. A **linked list** is used to hold the tasks 
in memory, making it easy to add or remove tasks as needed.

In the app, we check the set before adding a new task. If the name already exists, we can tell the 
user and suggest combining similar tasks. The linked list stores tasks in the order they were 
entered, and it's easy to work with when adding or removing tasks.

The code uses a HashSet to make sure task names aren't duplicated, and a list that acts like a 
linked list to hold the task details. This helps the app stay organized and prevents confusion 
from repeated task names.

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
