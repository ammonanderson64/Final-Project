using System;
using System.Collections.Generic;

class LinkedListExample
{
    static void Main()
    {
        LinkedList<string> playlist = new LinkedList<string>();

        playlist.AddLast("Song A");
        playlist.AddLast("Song B");
        playlist.AddFirst("Intro Song");

        Console.WriteLine("Playlist:");
        foreach (var song in playlist)
        {
            Console.WriteLine(song);
        }

        playlist.Remove("Song B");
        Console.WriteLine("\nAfter removing Song B:");
        foreach (var song in playlist)
        {
            Console.WriteLine(song);
        }
    }
}

