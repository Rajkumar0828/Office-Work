using System;

namespace Array_negative_number_count
{
    class Program5
    {
        public static void Negcount()
        {
            {
            int[] number= {5,-3,8,-2,-7,1};
            
            int negativeCount=0;
                for (int i = 0; i < number.Length; i++)
            {
                    int num = number[i];
                    if (num < 0)
                {
                    negativeCount++;
                    


                }
                
            }
            Console.WriteLine("Number of negative elements in array " +negativeCount);
        }
        }
    }
}
