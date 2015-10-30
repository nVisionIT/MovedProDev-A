using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pro.Dev.A.Rest
{
    public class EmailModel
    {
        public string To { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        public string DeliveryType { get; set; }
    }
}
