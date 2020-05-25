using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Entities
{
    public class Ib_customer 
    {
        public int Ib_record_primary_key { get; set; }
        public string Ib_customer_name { get; set; }
        public string Ib_customer_registration { get; set; }
        public string Ib_customer_type { get; set; }
        public List<Ib_invoice> Customer_Invoice { get; set; }
        public List<Ib_address> Customer_Address { get; set; }
        public List<Ib_customer_contact> Customer_Contact { get; set; }
    }
}
