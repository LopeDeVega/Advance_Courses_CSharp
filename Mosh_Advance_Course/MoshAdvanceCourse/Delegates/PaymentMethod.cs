using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    public class PaymentMethod
    {
        public void CreditCard(string message)
        {
            Console.WriteLine($"Card Payment....{message}......CC");
        }

        public void PayPal(string message)
        {
            Console.WriteLine($"PayPal Payment....{message}.....PP");
        }
    }
}
