using System;
using System.Collections.Generic;

class SetExample
{
    static void Main()
    {
        HashSet<string> groceryList = new HashSet<string>();

        groceryList.Add("Apples");
        groceryList.Add("Bread");
        groceryList.Add("Milk");
        groceryList.Add("Apples"); // Duplicate, will not be added

        Console.WriteLine("Grocery List:");
        foreach (var item in groceryList)
        {
            Console.WriteLine(item);
        }

        groceryList.Remove("Milk");
        Console.WriteLine("\nAfter removing Milk:");
        foreach (var item in groceryList)
        {
            Console.WriteLine(item);
        }
    }
}
