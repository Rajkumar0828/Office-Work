using System;
namespace Second_largest_Array
{
    class Program7
    {
        public static void Large()
        {
            int [] numbers ={4,3,2,5,25,18,10};
             
            int largest =int.MinValue;
            int secondLargest = int.MinValue;
            
            foreach(int num in numbers)
            {
                if(num>  largest)
                {
                   secondLargest=largest;
                   largest =num;

                }
                else if (num > secondLargest && num!=largest)
                {
                    secondLargest =num;
                }

            }
            if (secondLargest !=int.MinValue)
            {
                Console.WriteLine("Second largest element in the array:" +secondLargest);

            }
            else
            {
               Console.WriteLine("NO largest element in the array");
            }
            Console.ReadLine();

        }
    }
}