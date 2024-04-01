using System;
namespace Merge_array_sorted;
class Program11
{
   public  static void Merge_array_sorted()
    {
        int[] array1 = { 1, 3, 5, 7, 9 };
        int[] array2 = { 2, 4, 6, 8, 10, 12, 14 };

        int[] mergedArray = MergeSortedArrays(array1, array2);

        Console.WriteLine("Merged Sorted Array:");
        foreach (int element in mergedArray)
        {
            Console.Write(element + " ");
        }

        Console.ReadKey();
    }

    static int[] MergeSortedArrays(int[] arr1, int[] arr2)
    {
        int totalLength = arr1.Length + arr2.Length;
        int[] mergedArray = new int[totalLength];

        int i = 0, j = 0, k = 0;

        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j])
            {
                mergedArray[k] = arr1[i];
                i++;
            }
            else
            {
                mergedArray[k] = arr2[j];
                j++;
            }
            k++;
        }

        while (i < arr1.Length)
        {
            mergedArray[k] = arr1[i];
            i++;
            k++;
        }

        while (j < arr2.Length)
        {
            mergedArray[k] = arr2[j];
            j++;
            k++;
        }

        return mergedArray;
    }
}
