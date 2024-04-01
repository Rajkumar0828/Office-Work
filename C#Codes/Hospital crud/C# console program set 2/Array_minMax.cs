using System;
namespace Array_Minmax;
class List
{
    public static void Array_Minmax(){
        Console.WriteLine("Enter the number of element to be stored in array");
int n=Convert.ToInt32(Console.ReadLine());
int[] arr=new int[n];
for(int i=0;i<n;i++){
    Console.WriteLine("Enter the element of "+i+" :");
    arr[i]=Convert.ToInt32(Console.ReadLine());
    
    
}

for(int i=0;i<n;i++){
    for(int j=i+1;j<n;j++){
        if(arr[i]>arr[j]){
                    (arr[j], arr[i]) = (arr[i], arr[j]);
                }
            }
 }
     Console.WriteLine("The Maximum element in the array is"+ arr[arr.Length-1]);
 Console.WriteLine("The Minimum element in the array is"+ arr[0]);

    }
    
}