using System;
class Program{
   public static void Main(string[] args){
        string Emp_name;
        int Employee_id;
        string Employee_designation;
        int Employee_salary;

        Console.WriteLine("Enter the Employee name : ");
        Emp_name = Console.ReadLine();
        Console.WriteLine("Enter the Employee id: ");
        Employee_id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Employee designation : ");
        Employee_designation= Console.ReadLine();
        Console.WriteLine("Enter the Employee salary : ");
        Employee_salary = Convert.ToInt32(Console.ReadLine());
        Console.ReadKey();
        Console.WriteLine("Employee Management System");
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Employee Name : " + Emp_name);
        Console.WriteLine("");
        Console.WriteLine("Employee Id : " + Employee_id);
        Console.WriteLine("");
        Console.WriteLine("Employee Designation : " + Employee_designation);
        Console.WriteLine("");
        Console.WriteLine("Employee Salary : " + Employee_salary);
        Console.WriteLine("");
        Console.ReadKey();

    }
}