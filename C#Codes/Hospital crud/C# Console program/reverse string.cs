using System;
namespace Reverse_String;

class Reverse{
    public static void Reverse_String(){
    Console.WriteLine("Enter the 1st letter :");
string first_let=Console.ReadLine();
Console.WriteLine("Enter the 2nd letter :");
string Second_let=Console.ReadLine();
Console.WriteLine("Enter the 3rd letter :");
string third_let=Console.ReadLine();
Console.WriteLine("Before reversing :");
Console.WriteLine(first_let + Second_let + third_let);
Console.WriteLine("After reversing :");
Console.WriteLine(third_let +" "+Second_let +" "+ first_let);

    }
}
