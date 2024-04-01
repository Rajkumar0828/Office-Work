using System;
using System.Diagnostics;
using Pomelo.EntityFrameworkCore.MySql.Storage.Internal;
using VehicleManagement.data;
using VehicleManagementSystem;

namespace VehicelConnection
{
    public class update
    {
       public static void UpdateVehicle(VehicleDbContext dbContext)
         {
        Console.WriteLine("Updating  values into the tables: ");
        Console.WriteLine("enter the id ");
         
        //  Console.WriteLine("4.Vehicle Number");
        //  Console.WriteLine("5.Owner Name");

        //   Console.Write("Enter Vehicle ID to update: ");
        
         
    
          if (int.TryParse(Console.ReadLine(), out int id))
          {
         var vehicleToUpdate = dbContext.Vehicles.Find(id);

          if (vehicleToUpdate != null)
           {
            Console.WriteLine("What you want to update");
        
         Console.WriteLine("1.Vehicle Type");
         Console.WriteLine("2.Vehicle Year");

            // Console.WriteLine("\n  updating Vehicle details:");
            // Console.WriteLine("What you want to update");
            // Console.WriteLine("1.Vehicle Type \n 2.Vehicel Model \n 3.Vehicel year");
        
            int updatechoice =int.Parse(Console.ReadLine());
            // string? updatedata=null;
    
            switch (updatechoice)
            {
                case 1:
                    //   updatedata="Type";
                       Console.Write("Enter Vehicle Type: ");
                       vehicleToUpdate.Type = Console.ReadLine();
                       break;

             
                case 2:
                    
                       Console.Write("Enter Vehicle Model: ");
                        vehicleToUpdate.Model = Console.ReadLine();
                       break;
                case 3:
                     int year;
                     Console.Write("Enter Vehicle Year: ");
                     while (!int.TryParse(Console.ReadLine(), out  year ))
         {
                 Console.WriteLine("Invalid input. Please enter a valid year.");
             }
            vehicleToUpdate.Year = year;
                
                break;
                 
                
                
            }
             
     
            // Console.Write("Enter Vehicle Type: ");
            // vehicleToUpdate.Type = Console.ReadLine();

            // Console.Write("Enter Vehicle Model: ");
            // vehicleToUpdate.Model = Console.ReadLine();

            // Console.Write("Enter Vehicle Year: ");
            // int year;
            // while (!int.TryParse(Console.ReadLine(), out  year ))
            // {
            //     Console.WriteLine("Invalid input. Please enter a valid year.");
            // }
            // vehicleToUpdate.Year = year;

            dbContext.SaveChanges();
            Console.WriteLine("Vehicle updated successfully!");
        }
        else
        {
            Console.WriteLine("Vehicle not found.");
        }
       }
        else
       {
        Console.WriteLine("Invalid input. Please enter a valid ID.");
        }
    
    
    }
    }
}