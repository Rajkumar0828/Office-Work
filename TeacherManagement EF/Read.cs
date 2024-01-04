using System;
using TeacherManagement.data;
using TeacherManagementSystem;


namespace  Teacher_CRUD
{
    public class Read
    {
       public  static void ViewAllTeachers(TeacherDbContext dbContext)
        {
           
         Console.Write("Enter Vehicle ID to view details: ");
          if (int.TryParse(Console.ReadLine(), out int id))
           {
           var Teacher = dbContext.Teachers.Find(id);

          if (Teacher != null)
           {
            Console.WriteLine($"Teacher ID: {Teacher.Teacher_Id}, Teacher Name: {Teacher.Teacher_Name}, Teacher Email: {Teacher.Teacher_Email}, Teacher Qualification: {Teacher.Teacher_Qualification},Teacher Location:{Teacher.Teacher_Location}");
            }
           else
           {
            Console.WriteLine("Teacher Details not found.");
           }
            }
          else
          {
        Console.WriteLine("Invalid input. Please enter a valid ID.");
           }
       
    }

    }
}