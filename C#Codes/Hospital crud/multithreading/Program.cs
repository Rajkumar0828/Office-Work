// using System;
// using System.Threading;

// class Program
// {
//     static void Main()
//     {
//         // Creating two threads for printing letters and numbers
//         Thread letterThread = new Thread(PrintLetters);
//         Thread numberThread = new Thread(PrintNumbers);

//         // Starting both threads
//         letterThread.Start();
//         numberThread.Start();

//         // Waiting for both threads to finish
//         letterThread.Join();
//         numberThread.Join();
//      Console.WriteLine("hi");
//         Console.ReadLine();
//     }

//     static void PrintLetters()
//     {
//         for (char c = 'A'; c <= 'E'; c++)
//         {
//             Console.WriteLine(c);
            
//              Thread.Sleep(500); // Adding a small delay for better visualization
//         }
//     }

//     static void PrintNumbers()
//     {
//         for (int i = 1; i <= 5; i++)
//         {
//             Console.Write(i);
//             // Thread.Sleep(1000); // Adding a small delay for better visualization
//         }
//     }
// }

using System;  
namespace FunctionExample  
{  
    class Program  
    {  
        // User defin----ed function  
        public void Show(string message)  
        {  
         Console.WriteLine("Inside Show Function"+message);  
 
        }  
        // Main function, execution entry point of the program  
        static void Main(string[] args)  
        {  
            Program program = new Program();  
            program.Show("Rahul Kumar");  
        
        }  
    }  
}  

