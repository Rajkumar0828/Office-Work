using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using MySql.Data.MySqlClient;

public delegate void Notification(string value); 
interface IDataConnection
{
    
    void AddData(MySqlConnection conn);
    void ReadData(MySqlConnection conn);
    void UpdateData(MySqlConnection conn);
    void DeleteData(MySqlConnection conn);
}
class VehicleDatabase : IDataConnection
{
    Notification Notification_message = delegate(string val) { 
        Console.WriteLine(val); 
         }; 

    public  void AddData(MySqlConnection conn)
    {
        conn.Open();
        Console.Write("Enter Vehicle Id: ");
        int? Vehicle_id = int.Parse(Console.ReadLine());

        Console.Write("Enter Vehicle Type: ");
        string? Vehicle_Type = Console.ReadLine();

        Console.Write("Enter Vehicle Name: ");
        string? Vehicle_Name = Console.ReadLine();

         Console.Write("Enter Vehicle Number: ");
        string? Vehicle_Number = Console.ReadLine();

        Console.Write("Enter Vehicle Owner Name: ");
        string? Owner_name = Console.ReadLine();

        string insertQuery = $"insert into vehicle( Vehicle_id ,Vehicle_Type, Vehicle_Name,Vehicle_Number,Owner_name) values({Vehicle_id} , '{Vehicle_Type}' ,'{Vehicle_Name}','{Vehicle_Number}','{Owner_name}')";
        MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
        cmd.ExecuteNonQuery();
        Notification_message("Data Inserted Successfully");
        conn.Close();

    }
    public  void ReadData(MySqlConnection conn)
    {
        conn.Open();
        string sql = "SELECT * FROM vehicle";
        MySqlCommand cmd = new MySqlCommand(sql, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();
        Console.WriteLine("Vehicle_ID       Vehicle_Type             Vehicel_Name                Vehicle_Number               Owner_Name");

        while (rdr.Read())
        {
            
            Console.WriteLine(rdr[0]+ "                " + rdr[1]+"                  "+ rdr[2] + "               " + rdr[3]+"              " +rdr[4]);
        }
        rdr.Close();
        conn.Close();

    }
    public  void UpdateData(MySqlConnection conn)
    {
        conn.Open();
        Console.WriteLine("Updating  values into the tables: ");
         Console.WriteLine("What you want to update");
         Console.WriteLine("1.Vehicle Id");
         Console.WriteLine("2.Vehicle Type");
         Console.WriteLine("3.Vehicle Name");
         Console.WriteLine("4.Vehicle Number");
         Console.WriteLine("5.Owner Name");

            string? updatechoice = Console.ReadLine();
            string? updatedata=null;
           switch(updatechoice){
            case "1":
                updatedata = "Vehicle_id";
                Console.Write("Enter the Vehicle ID: ");
                break;
            case "2":
                updatedata = "Vehicle_Type";
                Console.Write("Enter the  Type of Vehicle: ");
                break;
            case "3":
                updatedata = "Vehicle_Name";
                Console.Write("Enter the Vehicle Name: ");
                break;
            case "4":
                updatedata = "Vehicle_Number";
                Console.Write("Enter the Vehicle Number: ");
                break;
            case "5":
                updatedata = "Owner_name";
                Console.Write("Enter the Vehicle Owner Namer: ");
                break;

           }
        string? updatevalue = Console.ReadLine();
        Console.Write("\nEnter Vehicle id : ");
        string? Vehicle_id = Console.ReadLine();
        string UpdateQuery = $"UPDATE vehicle SET {updatedata}='{updatevalue}' where Vehicle_id ={Vehicle_id}";
        MySqlCommand cmd = new MySqlCommand(UpdateQuery, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();
        Notification_message("Data Updated Successfully");
        conn.Close();

    }
    public  void DeleteData(MySqlConnection conn)
    {
        conn.Open();
        Console.Write("\nEnter Vehicle name : ");
        string Vehicle_Name = Console.ReadLine()!;
        string DeleteQuery = $"delete from vehicle where Vehicle_Name='{Vehicle_Name}'";
        MySqlCommand cmd = new MySqlCommand(DeleteQuery, conn);
         cmd.ExecuteNonQuery();
         Notification_message("Data deleated successfully");

        conn.Close();
    }
}
class Program
{
  

    static void Main(string[] args)
    {
        string Str = "server=127.0.0.1;user=root;database=Vehicle_Management_system;port=3306;password=Password@12345";
        MySqlConnection conn = new MySqlConnection(Str);
        VehicleDatabase vehicleDatabase = new VehicleDatabase();
        
             

        while (true)
        {
            Console.WriteLine("Vehicle  Management System");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1. Add Vehicle");
            Console.WriteLine("2. View Vehicle");
            Console.WriteLine("3. Update Vehicle");
            Console.WriteLine("4. Delete Vehicle");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    vehicleDatabase.AddData(conn);

                    break;
                case "2":
                    vehicleDatabase.ReadData(conn);

                    break;
                case "3":
                    vehicleDatabase.UpdateData(conn);

                    break;
                case "4":
                    vehicleDatabase.DeleteData(conn);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}