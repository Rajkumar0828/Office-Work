using System;

// Define a generic delegate for arithmetic operations
public delegate T ArithmeticOperation<T>(T num1, T num2);

class Calculator
{


    // Generic method for addition
    static T Add<T>(T num1, T num2)
    {
        dynamic? a= num1, b = num2;
        return a + b;
    }

    // Generic method for subtraction
    static T Subtract<T>(T num1, T num2)
    {
        dynamic? a = num1, b = num2;
        return a - b;
    
    }
    


    static void Main()
    {
        // Create instances of the delegate for addition and subtraction
        ArithmeticOperation<int> addDelegate = Add;
        ArithmeticOperation<int> subtractDelegate = Subtract;
        

        // Perform addition
        Console.WriteLine("Enter First number");
         int num1=Convert.ToInt32(Console.ReadLine());
 
        Console.WriteLine("Enter the 2nd number");
        int num2=Convert.ToInt32(Console.ReadLine());
     

        int resultAddition = addDelegate(num1, num2);
        Console.WriteLine($"Answer is {resultAddition}");

        // Perform subtraction
       
     
        int resultSubtraction = subtractDelegate(num1, num2);
        Console.WriteLine($"Answer is {resultSubtraction}");
    }

    
    }


