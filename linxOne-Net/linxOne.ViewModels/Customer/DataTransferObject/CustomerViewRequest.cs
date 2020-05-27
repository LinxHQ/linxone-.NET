using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.ViewModels.Customer.DataTransferObject
{
    public class CustomerViewRequest
    {
        public int id { get; set; }
        public string name { get; set; }
        public string registration { get; set; }
        public string cus_type { get; set; }
    }
}
