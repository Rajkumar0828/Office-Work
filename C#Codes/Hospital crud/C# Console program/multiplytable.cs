using System;
namespace Multiply_table;

class Multiply{
    public static void Multiply_table(){
        Console.WriteLine("Enter the number");
        int num = Convert.ToInt32(Console.ReadLine());

        for(int i=0;i<=10;i++){
        int sum=num*i;
       Console.WriteLine(num+" * "+ i+" = "+sum );
    
    }
    }
}