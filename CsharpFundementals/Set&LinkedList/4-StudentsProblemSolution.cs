// SetLinkedListFixedChallenge.cs
using System;
using System.Collections.Generic;

class SetLinkedListFixedChallenge
{
    static void Main()
    {
        // Fixed Set logic: avoid adding null
        HashSet<string> tags = new HashSet<string>();
        tags.Add("Work");
        tags.Add("School");

        string newTag = "Home";
        if (!string.IsNullOrEmpty(newTag))
        {
            tags.Add(newTag);
        }

        Console.WriteLine("Tags:");
        foreach (var tag in tags)
        {
            Console.WriteLine(tag);
        }

        // Fixed LinkedList logic: check if item exists before removal
        LinkedList<string> books = new LinkedList<string>();
        books.AddLast("1984");
        books.AddLast("Brave New World");

        string bookToRemove = "The Great Gatsby";
        if (books.Contains(bookToRemove))
        {
            books.Remove(bookToRemove);
        }
        else
        {
            Console.WriteLine($"\n'{bookToRemove}' was not found in the book list.");
        }

        Console.WriteLine("\nBooks List:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}

