// /*using System;
// using System.Collections.Generic;

// class Program
// {
//     static List<Patient> patients = new List<Patient>();

//     static void Main()
//     {
//         while (true)
//         {
//             Console.WriteLine("Hospital Management System");
//             Console.WriteLine("1. Add Patient");
//             Console.WriteLine("2. View Patients");
//             Console.WriteLine("3. Exit");

//             Console.Write("Enter your choice: ");
//             string choice = Console.ReadLine();

//             switch (choice)
//             {
//                 case "1":
//                     AddPatient();
//                     break;
//                 case "2":
//                     ViewPatients();
//                     break;
//                 case "3":
//                     Environment.Exit(0);
//                     break;
//                 default:
//                     Console.WriteLine("Invalid choice. Please try again.");
//                     break;
//             }
//         }
//     }

//     static void AddPatient()
//     {
//         Console.Write("Enter patient name: ");
//         string name = Console.ReadLine();

//         Console.Write("Enter patient age: ");
//         int age = int.Parse(Console.ReadLine());

//         Console.Write("Enter patient case category: ");
//         string case_category = Console.ReadLine();


//         Patient newPatient = new Patient(name, age,case_category);
//         patients.Add(newPatient);

//         Console.WriteLine("Patient added successfully!\n");
//     }

//     static void ViewPatients()
//     {
//         if (patients.Count == 0)
//         {
//             Console.WriteLine("No patients available.\n");
//         }
//         else
//         {
//             Console.WriteLine("List of Patients:");
//             foreach (var patient in patients)
//             {
//                 Console.WriteLine($"Name: {patient.Name}, Age: {patient.Age}");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// class Patient
// {
//     public string Name { get; set; }
//     public int Age { get; set; }

//     public string Case_category { get; set; }

//     public Patient(string name, int age,string case_category)
//     {
//         Name = name;
//         Age = age;

//         Case_category= case_category;

//     }
// }*/
// using System;
// using System.Reflection;
// using MySql.Data.MySqlClient;
// class Program
// {

//     static void AddPatient()
//     {
//         string Str = "server=127.0.0.1;user=root;database=rajsql;port=3306;password=Password@12345";
//         MySqlConnection conn = new MySqlConnection(Str);
//         conn.Open();
//         Console.Write("Enter patient name: ");
//         string? name = Console.ReadLine();

//         Console.Write("Enter patient age: ");
//         int? age = int.Parse(Console.ReadLine());

//         Console.Write("Enter patient case category: ");
//         string? case_category = Console.ReadLine();

//         string insertQuery = "insert into patient( Patient_name,Age,Patient_case) values('" + name + "','" + age + "','" + case_category + "')";
//         MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
//         MySqlDataReader rdr = cmd.ExecuteReader();
//         conn.Close();




//         Console.WriteLine("Patient added successfully!\n");
//     }
//     static void ViewPatients()
//     {
//         string Str = "server=127.0.0.1;user=root;database=rajsql;port=3306;password=Password@12345";
//         MySqlConnection conn = new MySqlConnection(Str);
//         conn.Open();
//         string sql = "SELECT * FROM Patient";
//         MySqlCommand cmd = new MySqlCommand(sql, conn);
//         MySqlDataReader rdr = cmd.ExecuteReader();

//         while (rdr.Read())
//         {
//             Console.WriteLine(rdr[0] + " -- " + rdr[1] + "--" + rdr[2] + " -- " + rdr[3]);
//         }
//         rdr.Close();


//     }

//     static void UpdatePatients()
//     {
//         string Str = "server=127.0.0.1;user=root;database=rajsql;port=3306;password=Password@12345";
//         MySqlConnection conn = new MySqlConnection(Str);
//         conn.Open();
//         Console.WriteLine("Updating  values into the tables: ");
//         Console.Write("Enter the case: ");
//         string case_category = Console.ReadLine()!;
//         Console.Write("\nEnter id : ");
//         string ID = Console.ReadLine();
//         string insertQuery = $"UPDATE patient SET Patient_case='{case_category}' where Patient_ID ={ID}";
//         MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
//         MySqlDataReader rdr = cmd.ExecuteReader();
//         conn.Close();

//     }

//     static void DeletePatients()
//     {
//         string Str = "server=127.0.0.1;user=root;database=rajsql;port=3306;password=Password@12345";
//         MySqlConnection conn = new MySqlConnection(Str);
//         conn.Open();
//         Console.Write("\nEnter patient : ");
//         string name = Console.ReadLine()!;
//         string insertQuery = "DELETE FROM patient WHERE Patient_name='" + name + "';";
//         MySqlCommand cmd = new MySqlCommand(insertQuery, conn);
//         MySqlDataReader rdr = cmd.ExecuteReader();
//         conn.Close();


//     }

//     static void Main()
//     {

//         while (true)
//         {
//             Console.WriteLine("Hospital Management System");
//             Console.WriteLine("1. Add Patient");
//             Console.WriteLine("2. View Patients");
//             Console.WriteLine("3. Update Patient");
//             Console.WriteLine("4. Delete Patient");
//             Console.WriteLine("5. Exit");


//             Console.Write("Enter your choice: ");
//             string? choice = Console.ReadLine();

//             switch (choice)
//             {
//                 case "1":
//                     AddPatient();
//                     break;
//                 case "2":
//                     ViewPatients();
//                     break;
//                 case "3":
//                     UpdatePatients();
//                     break;
//                 case "4":
//                     DeletePatients();
//                     break;
//                 case "5":
//                     Environment.Exit(0);
//                     break;
//                 default:
//                     Console.WriteLine("Invalid choice. Please try again.");
//                     break;
//             }
//         }
//     }

// }