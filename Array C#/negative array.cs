using System;


namespace NegativeNumberArray
{
    class Program3
    {
        public static void neg()
        {
            int[] number= {5,-3,8,-2,-7,1,4,-5};
            
            Console.WriteLine("Negative elements in the array: ");
            
            foreach(int num in number)
            {
                if(num<0)
                {
                    Console.WriteLine(num);

                }
            }
        }

    }
}