using System;
using System.Collections.Generic;
public delegate double Student(double mark1, double mark2, double mark3);
class Marks
 {    
    public static double Total(double mark1, double mark2, double mark3)
    {
       return (mark1 + mark2 + mark3);    
       }

   public static double Average(double mark1, double mark2, double mark3)     {
         return ((mark1 + mark2 + mark3) / 3);
    }

 }

class Program
{

    public static void Main(string[] args)
    {        
        Student TotalMarks= Marks.Total;
         Student AverageMarks= Marks.Average;

     Console.WriteLine("Enter the first mark");
     int mark1=Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Enter the Second mark");
     int mark2=Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Enter the Third Mark");
     int mark3=Convert.ToInt32(Console.ReadLine());

     Double result1= PerformCalculation(mark1, mark2, mark3,TotalMarks);
     Double result2= PerformCalculation(mark1, mark2, mark3,AverageMarks);

     Console.WriteLine($"Ans:{result1}");
      Console.WriteLine($"Ans:{result2}");
     }
     static double PerformCalculation(double mark1, double mark2,double mark3,Student calculation)
     {
         return calculation(mark1,mark2,mark3);
    }

    }


 