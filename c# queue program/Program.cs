// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

class Program
{
    public static void Main(string[] args) 
    {
        Queue<string> personQueue = new Queue<string>();

        personQueue.Enqueue("raj");
       /* personQueue.Enqueue(new Person("Raj",22));
        personQueue.Enqueue(new Person("kumar",22));*/
        foreach (string s in personQueue)

        Console.WriteLine(s);
        Console.WriteLine("kavin");
    }
}
