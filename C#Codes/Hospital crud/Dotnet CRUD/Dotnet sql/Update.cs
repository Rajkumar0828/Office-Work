using System;
using MySql.Data.MySqlClient;
namespace Data_Update;

class Update
{
    public static void Data_Update()
    {
        string Str = "server=127.0.0.1;user=root;database=rajsql;port=3306;password=Password@12345";
    MySqlConnection conn = new MySqlConnection(Str);
        conn.Open();
        Console.WriteLine("Updating  values into the tables: ");
        Console.Write("Enter emp_id: ");
        string emp_id = Console.ReadLine()!;
        Console.Write("\nEnter ename : ");
        string ename = Console.ReadLine()!;
        string insertQuery = "UPDATE employee SET ename='"+ename+"' WHERE emp_id ="+emp_id+"";
        MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();
        conn.Close();
        Console.WriteLine("Values Updated successfully.....");

    }
}