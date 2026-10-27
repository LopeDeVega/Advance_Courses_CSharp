using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Delegates
{
   public class NotificationChannel
    {
        public void GetSms()
        {
            Console.WriteLine("Sending SMS...............");
        }

        public void GetEmail()
        {
            Console.WriteLine("Sending Email.....!!!!!!!!!!!!!");
        }
    }
}
