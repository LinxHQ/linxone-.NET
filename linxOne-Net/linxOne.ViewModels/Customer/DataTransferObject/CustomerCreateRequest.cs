using linxOne.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.ViewModels.Customer.DataTransferObject
{
    public class CustomerCreateRequest
    {

        //public int Ib_record_primary_key { get; set; }
        public string Ib_customer_name { get; set; }
        public string Ib_customer_registration { get; set; }
        public string Ib_customer_type { get; set; }
        public List<Ib_invoice> Customer_Invoice { get; set; }
       
       
        //add subclass address by customer
        public List<Ib_address> Customer_Address { get; set; }
        public string Ib_customer_address_city { get; set; }
        public string Ib_customer_address_line_1 { get; set; }
        public string Ib_customer_address_line_2 { get; set; }
        public string Ib_customer_address_postal_code { get; set; }
        public string Ib_customer_address_phone_1 { get; set; }
        public string Ib_customer_address_phone_2 { get; set; }
        public string Ib_customer_address_state { get; set; }
        public string Ib_customer_address_website_url { get; set; }

        //add subclass customer_contact by customer
        public List<Ib_customer_contact> Customer_Contact { get; set; }
        public string Ib_customer_contact_email_1 { get; set; }
        public string Ib_customer_contact_email_2 { get; set; }
        public string Ib_customer_contact_first_name { get; set; }
        public string Ib_customer_contact_last_name { get; set; }
        public string Ib_customer_contact_mobile { get; set; }
        public string Ib_customer_contact_note { get; set; }
        public string Ib_customer_contact_office_fax { get; set; }
        public string Ib_customer_contact_office_phone { get; set; }
    }
}
