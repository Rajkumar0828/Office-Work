using System;
using VehicleManagement.data;
using VehicleManagementSystem;

namespace VehicelConnection

{

   public class Add
   {
       public static void AddVehicle(VehicleDbContext dbContext)
         {
            Console.WriteLine("\nEnter Vehicle details:");

            Console.Write("Enter Vehicle Type: ");
            string? type = Console.ReadLine();

            Console.Write("Enter Vehicle Model: ");
            string? model = Console.ReadLine();

            Console.Write("Enter Vehicle Year: ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.WriteLine("Invalid input. Please enter a valid year.");
            }

            var vehicle = new Vehicle
            {
                Type = type,
                Model = model,
                Year = year
            };

            dbContext.Vehicles.Add(vehicle);
            dbContext.SaveChanges();

            Console.WriteLine("Vehicle added successfully!");
        }

   }
}
