﻿using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Entities
{
    public class Ib_payment
    {
        public int Ib_record_primary_key { get; set; }
        public float Ib_amount { get; set; }
        public DateTime Ib_date { get; set; }
        public string Ib_Method { get; set; }
        public string Ib_no { get; set; }
        public string Ib_note { get; set; }
        public int Ib_invoice_id { get; set; }

    }
}
