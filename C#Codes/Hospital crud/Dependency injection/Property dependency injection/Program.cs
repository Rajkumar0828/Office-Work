using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Propertyinjection
{
                                        
    public interface ImessageService{   //interface use for representing a service
        void SendMessage(string message);
    }
    public class EmailService : ImessageService   //Concrete implementation of Imessageservice 
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending email: {message}");
        }
    }
    public class WhatsappService : ImessageService   //Concrete implementation of Imessageservice 
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending Whatsapp Message: {message}");
        }
    }


    public class NotificationService   //Class that depends on ImessageService through Constructor injection
    {

        public ImessageService MessageService { get; set; } // property for dependency injection


        public void NotifyUser(string username, string Message) // method that uses the injected dependency
        {
            string fullMessage = $"Hello,  {username}! {Message}";
            MessageService.SendMessage(fullMessage);
        }

                  
        
    }

    class Program
    {
        static void Main()
        {
            EmailService  emailService= new EmailService(); // create an instance for the service 
            WhatsappService  WhatsappService= new WhatsappService(); 

            NotificationService notificationservice = new NotificationService();  // create instance for service 
                       // create instance for service 

            notificationservice.MessageService = WhatsappService;
            // notificationservice.MessageService = emailService;

            notificationservice.NotifyUser("Rajkumar", "You have a new notification"); //Use the service

            Console.ReadLine();
        
        }
    }

      

    }
    