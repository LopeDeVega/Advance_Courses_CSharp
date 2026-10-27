using System.Net.Http.Headers;

namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            var operation = new Operation();

            calculator.PrintResult(5, 5, operation.Sum);
            calculator.PrintResult(5, 5, operation.Subract);

            var notification = new Notification();
            var channel = new NotificationChannel();
            notification.Notify(channel.GetSms);

            var method = new PaymentMethod();
            var processing = new PaymentProcessor();

            processing.ProcessPayment("Denied", method.CreditCard);
        }
    }
}
