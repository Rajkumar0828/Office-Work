using System;
namespace Search_element;
class Program13
{
    public static void Search_element()
    {
        int[] array = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

        int targetElement = 50;
        int targetIndex = SearchElement(array, targetElement);

        if (targetIndex != -1)
        {
            Console.WriteLine($"Element {targetElement} found at index {targetIndex}.");
        }
        else
        {
            Console.WriteLine($"Element {targetElement} not found in the array.");
        }

        Console.ReadKey();
    }

    static int SearchElement(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
            {
                return i; // Element found, return its index
            }
        }
        return -1; // Element not found
    }
}
