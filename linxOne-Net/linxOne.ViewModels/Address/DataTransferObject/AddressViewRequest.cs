using linxOne.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.ViewModel.Address.DataTransferObject
{
   public class AddressViewRequest
    {
        public string Ib_customer_address_city { get; set; }
        public string Ib_customer_address_line_1 { get; set; }
        public string Ib_customer_address_line_2 { get; set; }
        public string Ib_customer_address_phone_1 { get; set; }
        public string Ib_customer_address_phone_2 { get; set; }
        public string Ib_customer_address_postal_code { get; set; }
        public string Ib_customer_address_state { get; set; }
        public string Ib_customer_address_website_url { get; set; }
        public int Ib_customer_id { get; set; }
        public Ib_customer Customer { get; set; }
    }
}
