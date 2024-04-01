using System.Data;
using MySql.Data.MySqlClient;
using Data_Insert;
using Data_Update;
using Data_Delete;
using Data_Create;

class Read{
public static void Main(String[] args) {
    string connStr = "server=127.0.0.1;user=root;database=rajsql;port=3306;password=Password@12345";
         MySqlConnection conn= new MySqlConnection(connStr);
        try
        {
            Console.WriteLine("Connecting to MySQL...");
            conn.Open();
            
            Create.Data_Create();
            string sql = "SELECT * FROM EMPLOYEE";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Console.WriteLine(rdr[0] + " -- " + rdr[1]+"--"+rdr[2]);
            }
            rdr.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        conn.Close();
        Console.WriteLine("Done.");
Create.Data_Create();

}
}