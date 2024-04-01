using System;
using VehicleManagement.data;
using VehicleManagementSystem;


namespace VehicelConnection
{
    public class view
    {
       public  static void ViewAllVehicles(VehicleDbContext dbContext)
        {
           
         Console.Write("Enter Vehicle ID to view details: ");
          if (int.TryParse(Console.ReadLine(), out int id))
           {
           var vehicle = dbContext.Vehicles.Find(id);

          if (vehicle != null)
           {
            Console.WriteLine($"Type: {vehicle.Type}, Model: {vehicle.Model}, Year: {vehicle.Year}");
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