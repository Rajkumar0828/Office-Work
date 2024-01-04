using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Teacher_CRUD;
using TeacherManagement.data;

namespace TeacherManagementSystem
{
   public class Program
    {
        public static string GetDbConnection()
        {
            var builder = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
 
            string? strConnection = builder.Build().GetConnectionString("DefaultConnection");
 
            return strConnection;
        }
        static void Main(string[] args)
        {
            using (var dbContext = new TeacherDbContext())
            {
                Console.WriteLine("Welcome to the Teacher Management System!");

                bool isRunning = true;
                while (isRunning)
                {
                    Console.WriteLine("\nMenu:");
                    Console.WriteLine("1. Add a Teacher Details");
                    Console.WriteLine("2. View all Teacher Details");
                    Console.WriteLine("3. Update Teacher Details");
                    Console.WriteLine("4. Delete Teacher Details");
                    Console.WriteLine("5. Exit");

                    Console.Write("Enter your choice: ");
                    int choice;
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                Add.AddTeacher(dbContext);
                                break;
                            case 2:
                                Read.ViewAllTeachers(dbContext);
                                break;


                            case 3:
                                 Update.UpdateTeacher(dbContext);
                                 break;
                            case 4:
                                Delete.DeleteTeacher(dbContext);
                                 break;
                            case 5:
                                isRunning = false;
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please try again.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }
            }
        }
    }
}