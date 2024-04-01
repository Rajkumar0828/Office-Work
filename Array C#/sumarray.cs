using System;

namespace Array_Number_sum
{
    class Program4
    {
        public static void sum()
        {
            int[] numbers={20,45,88,90,75};
            int sum=0;
            
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine("sum of elements in the arrary: " + sum);
        }
    }
}