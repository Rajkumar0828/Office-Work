using System;
using CSharpGeneric;
namespace CSharpGeneric  
{  

    public abstract class  Course<TSubject>
    {
        public abstract void GetMarks(TSubject subject, int marks);
    }

    public class Student<TSubject> : Course<TSubject>
    {
        public override void GetMarks(TSubject subject, int marks)
        {
            Console.WriteLine($"Subject: {subject} Marks:{marks}");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student<string> student1 =new Student<string>();
        student1.GetMarks("c#", 97);
         Student<string> student2 =new Student<string>();
        student2.GetMarks("c#", 77);
    }
}


