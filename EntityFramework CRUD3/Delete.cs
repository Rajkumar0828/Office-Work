using System;
using VehicleManagement.data;
using VehicleManagementSystem;

namespace VehicelConnection
{
    public class delete
    {
       public static void DeleteVehicle(VehicleDbContext dbContext)
      {
       Console.Write("Enter Vehicle ID to delete: ");
        if (int.TryParse(Console.ReadLine(), out int id))
       {
        var vehicleToDelete = dbContext.Vehicles.Find(id);

        if (vehicleToDelete != null)
        {
            dbContext.Vehicles.Remove(vehicleToDelete);
            dbContext.SaveChanges();
            Console.WriteLine("Vehicle deleted successfully!");
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


    



    