// SetLinkedListBuggedChallenge.cs
using System;
using System.Collections.Generic;

class SetLinkedListBuggedChallenge
{
    static void Main()
    {
        // Set challenge with bug: trying to add null
        HashSet<string> tags = new HashSet<string>();
        tags.Add("Work");
        tags.Add("School");
        tags.Add(null); // Bug 1: Adding null - may cause confusion or runtime error depending on context

        Console.WriteLine("Tags:");
        foreach (var tag in tags)
        {
            Console.WriteLine(tag);
        }

        // LinkedList challenge with bug: incorrect removal
        LinkedList<string> books = new LinkedList<string>();
        books.AddLast("1984");
        books.AddLast("Brave New World");

        books.Remove("The Great Gatsby"); // Bug 2: Trying to remove an item that doesn't exist

        Console.WriteLine("\nBooks List:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}

