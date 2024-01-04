using System;
using TeacherManagement.data;
using TeacherManagementSystem;

namespace Teacher_CRUD
{
    public class Delete
    {
       public static void DeleteTeacher(TeacherDbContext dbContext)
      {
       Console.Write("Enter Teacher ID to delete: ");
        if (int.TryParse(Console.ReadLine(), out int id))
       {
        var TeacherToDelete = dbContext.Teachers.Find(id);

        if (TeacherToDelete != null)
        {
            dbContext.Teachers.Remove(TeacherToDelete);
            dbContext.SaveChanges();
            Console.WriteLine("Teacher Details deleted successfully!");
        }
        else
        {
            Console.WriteLine("Teacher Details not found.");
        }
        }
        else
        {
        Console.WriteLine("Invalid input. Please enter a valid Teacher ID.");
        }
      }
        
        
    }


}