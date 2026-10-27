using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    internal class Notification
    {
        public void Notify( Action send )
        {
            send();
        }
    }
}
