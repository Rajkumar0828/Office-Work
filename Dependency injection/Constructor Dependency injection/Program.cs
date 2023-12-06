using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructorinjection
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

    public class NotificationService   //Class that depends on ImessageService through Constructor injection
    {

        private readonly ImessageService _messageService;

                  
        public NotificationService(ImessageService messageService)  //constructor injection
        {
            _messageService = messageService;
        }
         public void NotifyUser(string username, string message) //method that uses the injected dependecny
      {
         string fullMessage =$"Hello, {username}!{message}";    
         _messageService.SendMessage(fullMessage);
      }
    }

    class Program
    {
        static void Main()
        {
            var  emailService= new EmailService(); // create an instance for the service 

            var notificationservice = new NotificationService(emailService);  // inject the dependency through constructor

            notificationservice.NotifyUser("Rajkumar", "You have a new notification"); //Use the service

            Console.ReadLine();
        
        }
    }

      

    }
    

