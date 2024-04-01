using System;

class Program
{
    static int SearchElement(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i; // Element found, return its index
            }
        }
        
        return -1; // Element not found
    }

    static void Main(string[] args)
    {
        int[] array = { 10, 20, 30, 40, 50 };
        int targetElement = 30;

        int index = SearchElement(array, targetElement);

        if (index != -1)
        {
            Console.WriteLine($"Element {targetElement} found at index {index}");
        }
        else
        {
            Console.WriteLine($"Element {targetElement} not found in the array");
        }
    }
}