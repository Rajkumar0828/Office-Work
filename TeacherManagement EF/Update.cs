using System;
using System.Diagnostics;
using Pomelo.EntityFrameworkCore.MySql.Storage.Internal;
using TeacherManagement.data;
using TeacherManagementSystem;

namespace Teacher_CRUD
{
    public class Update
    {
       public static void UpdateTeacher(TeacherDbContext dbContext)
         {
        Console.WriteLine("Updating  values into the tables: ");
        Console.WriteLine("enter the Teacher id ");

        
          if (int.TryParse(Console.ReadLine(), out int id))
          {
         var TeacherToUpdate = dbContext.Teachers.Find(id);

          if (TeacherToUpdate != null)
           {
            Console.WriteLine("What you want to update");
        
            Console.WriteLine("1.Teacher Name");
            Console.WriteLine("2.Teacher Email");
            Console.WriteLine("3.Teacher Qualification");
            Console.WriteLine("4.Teacher Loacation");



         int updatechoice =int.Parse(Console.ReadLine());
            // string? updatedata=null;
    
            switch (updatechoice)
            {
                case 1:
                    //   updatedata="Type";
                       Console.Write("Enter Vehicle Name: ");
                       TeacherToUpdate.Teacher_Name  = Console.ReadLine();
                       break;

             
                case 2:
                    
                       Console.Write("Enter Teacher Email: ");
                       TeacherToUpdate.Teacher_Email= Console.ReadLine();
                       break;
                case 3:
                      Console.Write("Enter Teacher Qualification: ");
                       TeacherToUpdate.Teacher_Qualification= Console.ReadLine();
                       break;
                case 4:
                      Console.Write("Enter Teacher Location: ");
                       TeacherToUpdate.Teacher_Location= Console.ReadLine();
                       break;
                 
                
                
            }

             dbContext.SaveChanges();
            Console.WriteLine("Teacher  Details updated successfully!");
        }
        else
        {
            Console.WriteLine("Teacher Detail not found.");
        }
       }
        else
       {
        Console.WriteLine("Invalid input. Please enter a valid  Teacher ID.");
        }
    
    
    }
    }
}