using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Entities
{
    public class Ib_invoice_item
    {
        public int Ib_record_primary_key { get; set; }
        public int Ib_invoice_product_id { get; set; }
        public Ib_product Product { get; set; }
        public int Ib_invoice_id { get; set; }
        public Ib_invoice Invoice { get; set; }
        public float Ib_invoice_item_quantity { get; set; }
        public float Ib_invoice_item_tota { get; set; }
        public float Ib_invoice_item_value { get; set; }
        

    }
}
