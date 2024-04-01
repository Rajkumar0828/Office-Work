using System;
namespace odd_even_number;

class Number{
    public static void Odd_even_number(){

        Console.WriteLine("Enter 1st number");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2nd number");
int num2=Convert.ToInt32(Console.ReadLine());
bool isSame=true;
bool isDiff=false;

int sum1;
int sum2;
if(num1%2==0){
    sum1=0;
}else{
  sum1=1;  
}
if(num2%2==0){
    sum2=0;
}else{
  sum2=1;  
}
if(sum1==sum2){
    Console.WriteLine(isSame);
}
else{
    Console.WriteLine(isDiff);
}

    }
}