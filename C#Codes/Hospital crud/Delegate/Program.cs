using System;
using System.Collections.Generic;
public delegate double CalculationDelegate(Double x, Double y);

class Calculator
{
    public static double Add(double x, double y)
    {
        return x + y;
    }
    public static double Sub(double x, double y)
    {
        return x - y;
    }
    public static double Multiply(double x, double y)
    {
        return x * y;
    }
    public static double Divide(double x, double y)
    {
        if(y!=0)
        {
            return x/y;

        }
        else 
        {
            Console.WriteLine("cannot divide by zero");
            return double.NaN;
        }
    }
}

class Program{
    static void Main(string[] args) {
       CalculationDelegate addDelegate =  Calculator.Add;
      CalculationDelegate SubDelegate = Calculator.Sub;
     CalculationDelegate MultiplyDelegate = Calculator.Multiply;
     CalculationDelegate DivideDelegate = Calculator.Divide;
     Console.WriteLine("Enter the 1st number");
     int x=Convert.ToInt32(Console.ReadLine());
     Console.WriteLine("Enter the 2nd number");
     int y=Convert.ToInt32(Console.ReadLine());
     
    Double result1= PerformCalculation(x, y, SubDelegate);

     Console.WriteLine($"Ans:{result1}");
     }
     static double PerformCalculation(double x, double y,CalculationDelegate calculation)
     {
         return calculation(x,y);
    }


    
}

// class Program
// {
//     // define a method that returns sum of two int numbers 
//     static int calculateSum(int x, int y)
//     {
//         return x + y;
//     }

//     // define a delegate
//     public delegate int myDelegate(int num1, int num2);

//     static void Main()
//     {
//  // create an instance of delegate by passing method name 
//         myDelegate d = new myDelegate(calculateSum);

//  // calling calculateSum() using delegate
//         int result = d(5, 6);

//         Console.WriteLine(result);
//     }
// }
