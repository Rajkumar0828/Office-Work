using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VehicelConnection;
using VehicleManagement.data;
using VehicleManagementSystem;
namespace VehicleManagementSystem
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
            using (var dbContext = new VehicleDbContext())
            {
                Console.WriteLine("Welcome to the Vehicle Management System!");

                bool isRunning = true;
                while (isRunning)
                {
                    Console.WriteLine("\nMenu:");
                    Console.WriteLine("1. Add a Vehicle");
                    Console.WriteLine("2. View all Vehicles");
                    Console.WriteLine("3. Update Vehicles");
                    Console.WriteLine("4. Delete Vehicles");
                    Console.WriteLine("5. Exit");

                    Console.Write("Enter your choice: ");
                    int choice;
                    if (int.TryParse(Console.ReadLine(), out choice))
                    {
                        switch (choice)
                        {
                            case 1:
                                Add.AddVehicle(dbContext);
                                break;
                            case 2:
                                view.ViewAllVehicles(dbContext);
                                break;


                            case 3:
                            update.UpdateVehicle(dbContext);
                             break;
                             case 4:
                            delete.DeleteVehicle(dbContext);
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

        //  static void AddVehicle(VehicleDbContext dbContext)
        //  {
        //     Console.WriteLine("\nEnter Vehicle details:");

        //     Console.Write("Enter Vehicle Type: ");
        //     string? type = Console.ReadLine();

        //     Console.Write("Enter Vehicle Model: ");
        //     string? model = Console.ReadLine();

        //     Console.Write("Enter Vehicle Year: ");
        //     int year;
        //     while (!int.TryParse(Console.ReadLine(), out year))
        //     {
        //         Console.WriteLine("Invalid input. Please enter a valid year.");
        //     }

        //     var vehicle = new Vehicle
        //     {
        //         Type = type,
        //         Model = model,
        //         Year = year
        //     };

        //     dbContext.Vehicles.Add(vehicle);
        //     dbContext.SaveChanges();

        //     Console.WriteLine("Vehicle added successfully!");
        // }

        // static void ViewAllVehicles(VehicleDbContext dbContext)
        // {
           
        //  Console.Write("Enter Vehicle ID to view details: ");
        //   if (int.TryParse(Console.ReadLine(), out int id))
        //    {
        //    var vehicle = dbContext.Vehicles.Find(id);

        //   if (vehicle != null)
        //    {
        //     Console.WriteLine($"Type: {vehicle.Type}, Model: {vehicle.Model}, Year: {vehicle.Year}");
        //     }
        //    else
        //    {
        //     Console.WriteLine("Vehicle not found.");
        //    }
        //     }
        //   else
        //   {
        // Console.WriteLine("Invalid input. Please enter a valid ID.");
        //    }
       
       
       
        // }
    //      static void UpdateVehicle(VehicleDbContext dbContext)
    //      {
    //       Console.Write("Enter Vehicle ID to update: ");
    //       if (int.TryParse(Console.ReadLine(), out int id))
    //       {
    //     var vehicleToUpdate = dbContext.Vehicles.Find(id);

    //       if (vehicleToUpdate != null)
    //        {
    //         Console.WriteLine("\nEnter updated Vehicle details:");

    //         Console.Write("Enter Vehicle Type: ");
    //         vehicleToUpdate.Type = Console.ReadLine();

    //         Console.Write("Enter Vehicle Model: ");
    //         vehicleToUpdate.Model = Console.ReadLine();

    //         Console.Write("Enter Vehicle Year: ");
    //         int year;
    //         while (!int.TryParse(Console.ReadLine(), out  year ))
    //         {
    //             Console.WriteLine("Invalid input. Please enter a valid year.");
    //         }
    //         vehicleToUpdate.Year = year;

    //         dbContext.SaveChanges();
    //         Console.WriteLine("Vehicle updated successfully!");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Vehicle not found.");
    //     }
    //    }
    //     else
    //    {
    //     Console.WriteLine("Invalid input. Please enter a valid ID.");
    //     }
    
    
    // }
    //    static void DeleteVehicle(VehicleDbContext dbContext)
    //   {
    //    Console.Write("Enter Vehicle ID to delete: ");
    //     if (int.TryParse(Console.ReadLine(), out int id))
    //    {
    //     var vehicleToDelete = dbContext.Vehicles.Find(id);

    //     if (vehicleToDelete != null)
    //     {
    //         dbContext.Vehicles.Remove(vehicleToDelete);
    //         dbContext.SaveChanges();
    //         Console.WriteLine("Vehicle deleted successfully!");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Vehicle not found.");
    //     }
    //     }
    //     else
    //     {
    //     Console.WriteLine("Invalid input. Please enter a valid ID.");
    //     }
    //   }
        
        
    }


}


    

