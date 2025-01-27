using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign.Q03
{
    internal interface INotificationService
    {
        public void SendNotification(string recipient, string message);
    }

    class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine("Email Message" + recipient + "   " + message);
        }
    }
    class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine("SMS Message" + recipient + "   " + message);
        }
    }
    class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            Console.WriteLine("Service Notification"+ recipient+ "   "+message );
            
        }
    }
}
