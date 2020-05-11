using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.Data.Entities
{
    public class Ib_product
    {
        public int Ib_record_primary_key { get; set; }
        public string Ib_product_description { get; set; }
        public string Ib_product_name { get; set; }
        public double Ib_product_price { get; set; }
        public decimal Ib_product_tax { get; set; }

        public List<Ib_invoice_item> Invoice_Item_Product { get; set; }

    }
}
