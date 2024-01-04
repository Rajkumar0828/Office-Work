// using System;
// using System.Collections.Generic;

// // Define the Patient class
// public class Patient
// {
//     public string?Name { get; set; }
//     public int Age { get; set; }

//     public override string ToString()
//     {
//         return $"Name: {Name}, Age: {Age}";
//     }
// }

// // Define the PatientManagementSystem class
// public class PatientManagementSystem
// {
//     // Define delegate types
//     public delegate void AddPatientDelegate(Patient patient);
//     public delegate List<Patient> GetPatientsDelegate();

//     // Create delegate instances
//     public AddPatientDelegate AddPatient;
//     public GetPatientsDelegate GetPatients;

//     // Internal list to store patients
//     private List<Patient> patients;

//     public PatientManagementSystem()
//     {
//         patients = new List<Patient>();

//         // Assign delegate methods
//         AddPatient = new AddPatientDelegate(AddPatientMethod);
//         GetPatients = new GetPatientsDelegate(GetPatientsMethod);
//     }

//     // Delegate method to add a patient
//     private void AddPatientMethod(Patient patient)
//     {
//         patients.Add(patient);
//         Console.WriteLine($"Patient added: {patient}");
//     }

//     // Delegate method to retrieve all patients
//     private List<Patient> GetPatientsMethod()
//     {
//         return patients;
//     }
// }

// class Program2
// {
//     static void Main()
//     {
//         // Create an instance of the PatientManagementSystem
//         PatientManagementSystem patientSystem = new PatientManagementSystem();

//         // Use delegate methods to add and retrieve patients
//         patientSystem.AddPatient(new Patient { Name = "John Doe", Age = 30 });
//         patientSystem.AddPatient(new Patient { Name = "Jane Doe", Age = 25 });

//         List<Patient> allPatients = patientSystem.GetPatients();

//         // Display all patients in the console
//         Console.WriteLine("\nAll Patients:");
//         foreach (Patient patient in allPatients)
//         {
//             Console.WriteLine(patient);
//         }
//     }
// }