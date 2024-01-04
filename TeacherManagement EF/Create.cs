using System;
using TeacherManagement.data;
using TeacherManagementSystem;

namespace Teacher_CRUD

{

   public class Add
   {
       public static void AddTeacher(TeacherDbContext dbContext)
         {
            Console.WriteLine("\nEnter Teacher details:");

            Console.Write("Enter Teacher ID: ");
            int T_id = int.Parse(Console.ReadLine());

            Console.Write("Enter Teacher Name: ");
            string? T_name = Console.ReadLine();

            Console.Write("Enter Teacher Email: ");
            string? T_email = Console.ReadLine();

            Console.Write("Enter Teacher Qualification: ");
            string? T_qualification = Console.ReadLine();

             Console.Write("Enter Teacher Location: ");
            string? T_location = Console.ReadLine();

            

          
            var  Teacher = new Teacher
            {
                Teacher_Id  = T_id,
                Teacher_Name = T_name,
                Teacher_Email= T_email,
                Teacher_Qualification =T_qualification,
                Teacher_Location=T_location,
            };

            dbContext.Teachers.Add(Teacher);
            dbContext.SaveChanges();

            Console.WriteLine("Teacher Details added successfully!");
        }

   }
}
