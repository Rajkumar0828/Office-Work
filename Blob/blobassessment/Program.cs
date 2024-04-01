using System;
using System.IO;
using System.Text.Json;

namespace raj
{
    public class UserData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        // public string ChickenOrEgg { get; set; }
    }

    class Assignment
    {
        public static  void AddData()
        {
            Console.WriteLine("Enter your first name.");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name.");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your job title.");
            string jobTitle = Console.ReadLine();
            // Console.WriteLine("What came first, the chicken or the egg?");
            // string chickenEgg = Console.ReadLine();

            string path = @"D:\C# codes\New folder\BlobQuickstart\data\workingfile.txt";

            var data = new UserData
            {
                FirstName = firstName,
                LastName = lastName,
                JobTitle = jobTitle,
                // ChickenOrEgg = chickenEgg
            };

            string jsonString = JsonSerializer.Serialize(data);

            if (File.Exists(path))
            {
                File.AppendAllText(path, jsonString + Environment.NewLine);
            }
            else
            {
                File.WriteAllText(path, jsonString + Environment.NewLine);
            }

            Console.WriteLine("Your information has been recorded. A copy can be found on your desktop.");
        }
       public static  void  viewData()
        {
            Console.WriteLine("Employee Details");
            Console.WriteLine("--------------------------");
            
            // Deserialize the JSON file and print the output
            string pathToRead = @"D:\C# codes\New folder\BlobQuickstart\data\workingfileDOWNLOADED.txt";


            if (File.Exists(pathToRead))
            {
                string[] lines = File.ReadAllLines(pathToRead);
                foreach (string line in lines)
                {
                    var deserializedData = JsonSerializer.Deserialize<UserData>(line);
                    Console.WriteLine($"First Name: {deserializedData.FirstName}");
                    Console.WriteLine($"Last Name: {deserializedData.LastName}");
                    Console.WriteLine($"Job Title: {deserializedData.JobTitle}");
                    // Console.WriteLine($"Chicken or Egg: {deserializedData.ChickenOrEgg}");
                }
            }
            else
            {
                Console.WriteLine("The file to be deserialized does not exist.");
            }

        }
    }

    class program
{
    
    static void Main(string[] args)
    {
            Console.WriteLine("Employee Management System");
            Console.WriteLine("--------------------------");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Display Employee");
            Console.Write("Enter your choice: ");
            string? choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                     Assignment.AddData();

                    break;
                case "2":
                     Assignment.viewData();

                    break;
                
    }

    }
}

}



