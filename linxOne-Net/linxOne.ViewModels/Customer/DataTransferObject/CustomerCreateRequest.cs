using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.ViewModels.Customer.DataTransferObject
{
    public class CustomerCreateRequest
    {

        public int Ib_record_primary_key { get; set; }
        public string Ib_customer_name { get; set; }
        public string Ib_customer_registration { get; set; }
        public string Ib_customer_type { get; set; }
    }
}
