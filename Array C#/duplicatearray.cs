using System;
using System.Collections.Generic;
namespace Dupicate_array;
class Program10
{
    public static void Dup()
    {
        int[] array = { 1, 2, 3, 4, 2, 5, 6, 1, 7, 8, 9, 9, 5 };

        // Create a HashSet to store unique elements
        HashSet<int> uniqueElements = new HashSet<int>();

        // Create a list to store the elements without duplicates
        List<int> arrayWithoutDuplicates = new List<int>();

        // Iterate through the array and add unique elements to the HashSet
        foreach (int element in array)
        {
            if (!uniqueElements.Contains(element))
            {
                uniqueElements.Add(element);
                arrayWithoutDuplicates.Add(element);
            }
        }

        // Convert the list back to an array
        int[] newArray = arrayWithoutDuplicates.ToArray();

        // Print the array without duplicates
        Console.WriteLine("Array without duplicates:");
        foreach (int element in newArray)
        {
            Console.Write(element + " ");
        }

        Console.ReadKey();
    }
}