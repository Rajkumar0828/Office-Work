using System;
namespace Reverse_array;
class Reverse
{
    public static void Reverse_array(){
        int[] arr=new int[10];
for(int i=0;i<10;i++){
    Console.WriteLine("Enter the element of "+i+" :");
    arr[i]=Convert.ToInt32(Console.ReadLine());
    
    
}
for(int i=0;i<10;i++){
   Console.WriteLine("element -"+i+" :"+" "+arr[i]);
}

foreach(int a in arr){
    Console.Write(a);
}

    }
}