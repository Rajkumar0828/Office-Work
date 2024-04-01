using System;
using MySql.Data.MySqlClient;
namespace Data_Insert;

class Insert{
public static void Data_Insert() {
    string Str = "server=127.0.0.1;user=root;database=rajsql;port=3306;password=Password@12345";
    MySqlConnection conn = new MySqlConnection(Str);
        conn.Open();
        Console.WriteLine("Inserting values into the tables: ");
        Console.Write("Enter emp_id: ");
        string emp_id = Console.ReadLine()!;
        Console.Write("\nEnter ename : ");
        string ename = Console.ReadLine()!;
        string insertQuery = "insert into employee( emp_id,ename) values('" +emp_id  + "','" + ename + "')";
        MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
        MySqlDataReader rdr = cmd.ExecuteReader();
        conn.Close();
        Console.WriteLine("Values inserted successfully.....");

}
}



class Program
{
    

    static void Main()
    {
         
        while (true)
        {
            Console.WriteLine("Hospital Management System");
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. View Patients");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddPatient();
                    break;
                /*case "2":
                    ViewPatients();
                    break;*/
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void AddPatient()
    {
        string Str = "server=127.0.0.1;user=root;database=rajsql;port=3306;password=Password@12345";
         MySqlConnection conn = new MySqlConnection(Str);         
         conn.Open();
        Console.Write("Enter patient name: ");
        string name = Console.ReadLine();

        Console.Write("Enter patient age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter patient case category: ");
        string case_category = Console.ReadLine();

        string insertQuery = "insert into patient( Patient_name,Age,Patient_case) values('" +name  + "','" + age + "','" + case_category + "')";
        MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
         MySqlDataReader rdr = cmd.ExecuteReader();
        conn.Close();


        

        Console.WriteLine("Patient added successfully!\n");
    }

    /*static void ViewPatients()
    {
        if (patients.Count == 0)
        {
            Console.WriteLine("No patients available.\n");
        }
        else
        {
            Console.WriteLine("List of Patients:");
            foreach (var patient in patients)
            {
                Console.WriteLine($"Name: {patient.Name}, Age: {patient.Age}");
            }
            Console.WriteLine();
        }
    }*/
}
