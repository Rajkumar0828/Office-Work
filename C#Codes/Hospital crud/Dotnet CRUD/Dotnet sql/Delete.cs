using System;
using MySql.Data.MySqlClient;
namespace Data_Delete;

class Delete
{
    public static void Data_Delete()
    {
        string Str = "server=127.0.0.1;user=root;database=rajsql;port=3306;password=Password@12345";
    MySqlConnection conn = new MySqlConnection(Str);
        conn.Open();
        Console.WriteLine("Deleting values from the tables: ");
        
        Console.Write("\nEnter ename : ");
        string ename = Console.ReadLine()!;
        string insertQuery = "DELETE FROM employee WHERE ename='"+ename+"';";
        MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();
        conn.Close();
        Console.WriteLine("Values Deleted successfully.....");

    }
}