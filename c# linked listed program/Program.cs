// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;  
using Linklist1;

namespace Link_list
{
  class Program
    {
       static void Main(string[] args)  
    {  
        var names = new LinkedList<string>();  
        names.AddLast("Sonoo Jaiswal");  
        names.AddLast("Ankit");  
        //dotfsnames.AddBefore(node,"kavin");
        names.AddLast("Irfan");  
        names.AddFirst("John");
        
        foreach (var name in names)  
        {  
            /*Console.WriteLine(name); */ 
        }  
        Program1.Linke_list1();
    }
  

    
    } 
}