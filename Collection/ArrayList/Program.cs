using System;
using System.Collections;
using Microsoft.VisualBasic;

public class Program
{
    public static void Main(string[] args)
    {
        var CourseList = new ArrayList();

        CourseList.Add("C#");
        CourseList.Add("python");
        CourseList.Add("Java");


        var CourseList2 = new ArrayList()
        {

            1,"Cloud Computing","Devops","Data Engineering"
        };

        Console.WriteLine("CourseList 1 Elements");

        for(int i = 0;i< CourseList.Count; i++) 
        Console.WriteLine(CourseList[i]);

        Console.WriteLine("CourseList 2 Elements");

        for(int i = 0;i< CourseList.Count; i++) 
        Console.WriteLine(CourseList2[i]);
    }

  
}
