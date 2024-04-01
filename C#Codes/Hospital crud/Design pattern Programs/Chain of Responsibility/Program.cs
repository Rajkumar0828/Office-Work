using System;

namespace LeavePortal
{
    //     Step 1: Define the Handler
    // First, we define an abstract handler that represents different handlers in the chain.


    public abstract class LeaveHandler
    {
        protected LeaveHandler successor;

        public void SetSuccessor(LeaveHandler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(LeaveRequest request);
    }


    //     Step 2: Create Concrete Handlers
    // These are specific handlers in the chain that decide either to process the request or pass it along.

    public class Supervisor : LeaveHandler
    {
        public override void HandleRequest(LeaveRequest request)
        {
            if (request.NumberOfDays < 3)
            {
                Console.WriteLine($"{request.EmployeeName}'s leave approved by L1 MANAGER GOWTHAM");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }

    public class Manager : LeaveHandler
    {
        public override void HandleRequest(LeaveRequest request)
        {
            if (request.NumberOfDays < 7)
            {
                Console.WriteLine($"{request.EmployeeName}'s leave approved by L2 Manager NIRMALA");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }

    public class Director : LeaveHandler
    {
        public override void HandleRequest(LeaveRequest request)
        {
            // Director can approve any number of days
            Console.WriteLine($"{request.EmployeeName}'s leave approved by L&D Director KARTHICK");
        }
    }

    // Step 3: Define a Request Class
    // This class represents requests passed along the chain.

    public class LeaveRequest
    {
        public string EmployeeName { get; set; }
        public int NumberOfDays { get; set; }

        public LeaveRequest(string employeeName, int numberOfDays)
        {
            EmployeeName = employeeName;
            NumberOfDays = numberOfDays;
        }
    }
   
//      Step 4: Using the Chain of Responsibility
// Now, we'll set up the chain and send a request through it.

  class Program
{
    static void Main(string[] args)
    {
        // Set up the chain
        LeaveHandler supervisor = new Supervisor();
        LeaveHandler manager = new Manager();
        LeaveHandler director = new Director();

        supervisor.SetSuccessor(manager);
        manager.SetSuccessor(director);

        // Make a request
        LeaveRequest request = new LeaveRequest(employeeName: "KAVIN", numberOfDays: 2);
        supervisor.HandleRequest(request);

        request = new LeaveRequest(employeeName: "ARUN", numberOfDays: 5);
        supervisor.HandleRequest(request);

        request = new LeaveRequest(employeeName: "RUBAN", numberOfDays: 10);
        supervisor.HandleRequest(request);
    }
}


}