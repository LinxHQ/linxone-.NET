﻿using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.ViewModels.Contact.DataTransferObject
{
    public class ContactViewRequest
    {
        public int Ib_record_primary_key { get; set; }
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
