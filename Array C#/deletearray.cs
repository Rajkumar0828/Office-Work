using System;
namespace delete_array;
class Program8
{
    public static void DEL ()
    {
        int[] originalArray = { 1, 2, 3, 4, 5 };
        int elementToDelete = 3;

        Console.WriteLine("Original Array:");
        PrintArray(originalArray);

        int[] modifiedArray = DeleteElement(originalArray, elementToDelete);

        Console.WriteLine("\nModified Array:");
        PrintArray(modifiedArray);
    }

    static int[] DeleteElement(int[] array, int element)
    {
        int index = Array.IndexOf(array, element);

        if (index >= 0)
        {
            // Shift elements left to overwrite the element to be deleted
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            // Resize the array to remove the last element (which is now duplicated)
            Array.Resize(ref array, array.Length - 1);
        }

        return array;
    }

    static void PrintArray(int[] array)
    {
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}