using System;

namespace Messagelogger
{

    //Step 1: Define the Product Interface

    //First, we define an interface for the types of objects the factory method will create. This interface will be implemented by the concrete products.

    public interface ILogger
    {
        void Log(string message);
    }



    //Step 2: Create Concrete Products

    //These are the specific implementations of the ILogger interface.

    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("ConsoleLogger: " + message);
        }
    }

    
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            // For simplicity, we're just printing out the message.
            // In a real application, you'd write the message to a file.
            Console.WriteLine("FileLogger: " + message);
        }
    }


     // Step 3: Define the Creator Class
    //This abstract class declares the factory method, which returns an object of type ILogger. 
    //Subclasses of LoggerCreator will implement this method to create specific logger objects.


    public abstract class LoggerCreator
    {
        // The factory method
        public abstract ILogger CreateLogger();

        public void LogMessage(string message)
        {
            // Call the factory method to create a Logger object.
            var logger = CreateLogger();
            logger.Log(message);
        }
    }
  
//     Step 4: Create Concrete Creators
//      These classes implement the factory method to create specific logger objects.


    public class ConsoleLoggerCreator : LoggerCreator
    {
        public override ILogger CreateLogger()
        {
            return new ConsoleLogger();
        }
    }

    public class FileLoggerCreator : LoggerCreator
    {
        public override ILogger CreateLogger()
        {
            return new FileLogger();
        }
    }

//     Step 5: Use the Factory Method
// Finally, let's use the Factory Method in our application.



    class Program
    {
        static void Main(string[] args)
        {
            LoggerCreator loggerCreator;

            // Decide which logger to use
            loggerCreator = new ConsoleLoggerCreator();
            loggerCreator.LogMessage("This is a console log.");

            loggerCreator = new FileLoggerCreator();
            loggerCreator.LogMessage("This is a file log.");
        }
    }



}
