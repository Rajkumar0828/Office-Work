using System;
using System.Collections.Generic;
namespace array_unique;
class Program9
{
   public static void Uniq()
    {
        int[] array = { 1, 2, 3, 4, 2, 5, 6, 1, 7, 8, 9, 9, 5 };

        // Create a HashSet to store unique elements
        HashSet<int> uniqueElements = new HashSet<int>();

        // Iterate through the array and add unique elements to the HashSet
        foreach (int element in array)
        {
            if (!uniqueElements.Contains(element))
            {
                uniqueElements.Add(element);
            }
        }

        // Print the unique elements
        Console.WriteLine("Unique elements in the array:");
        foreach (int uniqueElement in uniqueElements)
        {
            Console.Write(uniqueElement + " ");
        }

        Console.ReadKey();
    }
}