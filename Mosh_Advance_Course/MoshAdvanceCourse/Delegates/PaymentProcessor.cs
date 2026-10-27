using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    internal class PaymentProcessor
    {
        public void ProcessPayment (string message, Action<string> paymentVerification)
        {
            paymentVerification(message);
        }
    }
}
