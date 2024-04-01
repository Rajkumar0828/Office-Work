using System;
using MySql.Data.MySqlClient;
namespace Data_Create;

class Create
{
    public static void Data_Create()
    {
        string Str = "server=127.0.0.1;user=root;database=rajsql;port=3306;password=Password@12345";
    MySqlConnection conn = new MySqlConnection(Str);
        conn.Open();
         Console.WriteLine("Creating  the table: ");
        // Console.Write("Enter TableName: ");
        // string TableName = Console.ReadLine()!;
        // Console.WriteLine("\nEnter PersonID : ");
        // string PersonID = Console.ReadLine()!;
        // Console.WriteLine("\nEnter FirstName : ");
        // string FirstName = Console.ReadLine()!;
        // Console.WriteLine("\nEnter LastName : ");
        // string LastName = Console.ReadLine()!;
        
        string createQuery = "CREATE TABLE Person (PersonID int,FirstName varchar(255),LastName  varchar(255));";
        MySqlCommand cmd = new MySqlCommand(createQuery, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();
        conn.Close();
        Console.WriteLine("Table Created successfully.....");

    }
}