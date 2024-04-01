using System;
namespace Swap_number;

class Swap{
    public static void Swap_number(){
        int number1, number2, Swap_Number;
        Console.WriteLine("\n Enter First Number: ");
        number1= int.Parse(Console.ReadLine());

        Console.WriteLine("\nInput the Second Number: ");

        number2 = int.Parse(Console.ReadLine());
        
        Swap_Number = number1;
        
        number1= number2;
        number2=  Swap_Number;

        Console.Write("\nAfter Swapping: ");
        Console.Write("\nFirst Number: "+number1);
        Console.Write("\nSecond Number"+number2);
        Console.ReadKey();


    }
}