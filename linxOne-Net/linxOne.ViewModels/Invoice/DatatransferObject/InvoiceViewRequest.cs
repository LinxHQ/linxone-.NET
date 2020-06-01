using System;
using System.Collections.Generic;
using System.Text;

namespace linxOne.ViewModels.Invoice.DatatransferObject
{
    public class InvoiceViewRequest
    {
        public int Ib_record_primary_key { get; set; }
        public int Ib_invoice_customer_id { get; set; }
        public DateTime Ib_invoice_date { get; set; }
        public DateTime Ib_invoice_due_date { get; set; }
        public string Ib_invoice_encode { get; set; }
        public string Ib_invoice_no { get; set; }
        public string Ib_invoice_note { get; set; }
        public string Ib_invoice_subject { get; set; }
        public float Ib_invoice_subtotal { get; set; }
        public float Ib_invoice_total_after_discounts { get; set; }
        public float Ib_invoice_total_after_taxes { get; set; }
        public float Ib_invoice_total_outstanding { get; set; }
        public float Ib_invoice_total_paid { get; set; }

    }
}
