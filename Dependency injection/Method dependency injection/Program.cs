using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodinjection
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

    public class MessageSender   //Class that depends on ImessageService through method injection
    {

        public void SendNotification(ImessageService messageService,string recipient,string message)
        {
            string fullMessage = $"To:{recipient}\nMessage: {message}";
            messageService.SendMessage(fullMessage);

        }
    } 

    class Program
    {
        static void Main()
        {
            var  emailService= new EmailService(); // create an instance for the service 

            var MessageSender = new MessageSender();  // inject the dependency through constructor

            MessageSender.SendNotification(emailService, "rajkumar@relevantz.com","you have new notification!");


        
        }
    }

      

    }
    

