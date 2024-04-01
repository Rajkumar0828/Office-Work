using System;
namespace Empty_stack;
class Stack
{
    public static void Circle_radius(){
        Console.WriteLine("Enter the number of element to be stored in array");
int n=Convert.ToInt32(Console.ReadLine());
int[] arr=new int[n];
for(int i=0;i<n;i++){
    Console.WriteLine("Enter the element of "+i+" :");
    arr[i]=Convert.ToInt32(Console.ReadLine());
    
    
}
int sum=0;
for(int i=0;i<n;i++){
   sum = sum+arr[i];
   
}
Console.WriteLine($"Sum of a number is {sum}");
int Avg=sum/n;
Console.WriteLine($"Average of a number is {Avg}");

        

    }
}