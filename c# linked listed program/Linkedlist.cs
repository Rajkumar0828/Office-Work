using System;
namespace Linklist1;

class Program1
{
    public static void Linke_list1()
    {
        LinkedList<String> my_list = new LinkedList<String>();
 
        // Adding elements in the LinkedList
        // Using AddLast() method
        my_list.AddLast("Zoya");
        my_list.AddLast("Shilpa");
       var newNode =my_list.AddLast("Rohit");
        my_list.AddLast("Rohan");
        my_list.AddLast("Juhi");
        my_list.AddLast("Zoya");
        
       my_list.AddFirst("Rajkumar");
    
       var newNode = my_list.AddLast("Rohan");
       my_list.AddAfter(newNode,"Venkat");
        Console.WriteLine("Best students of Anna university:");
 
        // Accessing the elements of
        // LinkedList Using foreach loop
        foreach(string str in my_list)
        {
            Console.WriteLine(str);
        }
    }
}
