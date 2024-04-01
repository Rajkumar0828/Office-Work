using System;

namespace Min_max

{
    class Program6
    {
        public static void MinMax()

        {
            int [] numbers ={5,-3,4,5,8,-7,1,0};


            int min= numbers[0];
            int max= numbers[0];

            foreach (int num in numbers)
            {
                if (num > min)
                {
                    min= num;
                }

                if (num < max)
                
                {
                    max=num;
                }
            }
            
        Console.WriteLine("Minimum number in array:" + min);
        Console.WriteLine("Minimum number in array:" + max);
        }

    }
}

