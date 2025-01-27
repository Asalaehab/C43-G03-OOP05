using Assign.Q03;

namespace Assign
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q01
            IShape shape = new Circle() { R = 8.3M };
            shape.DisplayShapeInfo();

            IShape shape2 = new Rectangular()
            {
                Width = 20,
                Height = 5,
            };
            shape2.DisplayShapeInfo();
            #endregion

            #region Q02
            IAuthenticationService authenticationService = new BasicAuthenticationService();

            string? name;
            string? password;
            string? role;
            do
            {
                Console.Write("Enter your name : ");
                name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name));
            do
            {
                Console.Write("Enter your password : ");
                password = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(password));
            do
            {
                Console.Write("Enter your Role : ");
                role = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(role));

            if (authenticationService.AuthenticateUser(name, password)) Console.WriteLine("Valid  authencation");
            else Console.WriteLine("InValid Authentaction");
            if (authenticationService.AuthorizeUser(name, role)) Console.WriteLine("Valid Autherization");
            else Console.WriteLine("Invalid Autherization");
            #endregion


            #region Q03
            INotificationService notificationService = new EmailNotificationService();
            INotificationService notificationService1=new SmsNotificationService();
            INotificationService notificationService2=new PushNotificationService();
            string recipient = "example@example.com";
            string message = "Hello, this is a notification!";
            notificationService.SendNotification(recipient, message);
            notificationService1.SendNotification(recipient, message);
            notificationService2.SendNotification(recipient, message);

            #endregion
        }
    }
}