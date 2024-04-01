using System;
namespace Array_Minmax;
class Stack
{


    public int[] elements;
    public int top;

    public Stack(int size){
        elements=new int[size];
        top=-1;
    }
    public bool IsEmpty(){
        return top==-1;


    }
    public bool IsFull(){
        return top==elements.Length-1;
    }
    public void Push(int item)
    {
        if (IsFull())
        {
            Console.WriteLine("Stack Full!");
            return;
        }

        elements[++top] = item;
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack underflow");
            return -1;
        }

        return elements[top--];
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }

        return elements[top];
    }
    public static int Max(Stack stack)
    {
        if (stack.IsEmpty())
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }

        
        int max = stack.Peek();

        
        for (int i = stack.top; i >= 0; i--)
        {
            if (stack.elements[i] > max)
            {
                max = stack.elements[i];
            }
        }

        return max;
    }


    public static void Display(Stack stack)
    {
        if (stack.IsEmpty())
        {
            Console.WriteLine("Stack is empty");
            return;
        }

        Console.WriteLine("\nStack elements:");
        for (int i = stack.top; i >= 0; i--)
        {
            Console.Write(stack.elements[i]+" ");
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        
        Stack stack = new Stack(5);
        Console.WriteLine("Checking if stack is empty: " + stack.IsEmpty());
        
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);
        Stack.Display(stack);
        Console.WriteLine("\nTop element of the stack: " + stack.Peek());
        Console.WriteLine("\nChecking if stack is full: " + stack.IsFull());
        Console.WriteLine("\nPopping three elements from the stack:");
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Console.WriteLine(stack.Pop());
        Stack.Display(stack);
        Console.WriteLine("\nTop element of the stack: " + stack.Peek());
        int max = Stack.Max(stack);
        Console.WriteLine("\nMaximum element in the stack: " + max);
    }  
}

