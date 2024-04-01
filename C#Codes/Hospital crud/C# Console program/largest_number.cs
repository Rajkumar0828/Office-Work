using System;
namespace Largest_Of_number;

class Number{
    public static void Largest_Of_number(){
        Console.WriteLine("Enter 1st number");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 2nd number");
int num2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter 3rd number");
int num3=Convert.ToInt32(Console.ReadLine());
int a = (num1>num2)? num1 : num2;
int b = (a>num3)? a : num3;
Console.WriteLine($"The greatest number is {b}");

    }
}