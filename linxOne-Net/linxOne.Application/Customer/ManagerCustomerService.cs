using linxOne.Data.EF;
using linxOne.Data.Entities;
using linxOne.Utility.Exceptions;
using linxOne.ViewModel.Address.DataTransferObject;
using linxOne.ViewModel.Common;
using linxOne.ViewModels.Contact.DataTransferObject;
using linxOne.ViewModels.Customer.DataTransferObject;
using linxOne.ViewModels.Invoice.DatatransferObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linxOne.Application.Customer
{
    public class ManagerCustomerService : ICustomerService
    {
        private readonly linxOneDbContext db;
        public ManagerCustomerService(linxOneDbContext context)
        {
            db = context;
        }


        public async Task<int> Create(CustomerCreateRequest request)
        {
            var cus = new Ib_customer()
            {

                Ib_customer_name = request.Ib_customer_name,
                Ib_customer_registration = request.Ib_customer_registration,
                Ib_customer_type = request.Ib_customer_type,
                Customer_Address = new List<Ib_address>()
               {
                   new Ib_address()
                   {
                       Ib_customer_address_city =request.Ib_customer_address_city,
                       Ib_customer_address_line_1 =request.Ib_customer_address_line_1,
                       Ib_customer_address_line_2= request.Ib_customer_address_line_2,
                       Ib_customer_address_postal_code=request.Ib_customer_address_postal_code,
                       Ib_customer_address_phone_1=request.Ib_customer_address_phone_1,
                       Ib_customer_address_phone_2= request.Ib_customer_address_phone_2,
                       Ib_customer_address_state=request.Ib_customer_address_state,
                       Ib_customer_address_website_url=request.Ib_customer_address_website_url,
                 }
                },

                Customer_Contact = new List<Ib_customer_contact>()
               {

                   new Ib_customer_contact()
                   {
                       Ib_customer_contact_email_1 = request.Ib_customer_contact_email_1,
                       Ib_customer_contact_email_2 = request.Ib_customer_contact_email_2,
                       Ib_customer_contact_first_name=request.Ib_customer_contact_first_name,
                       Ib_customer_contact_last_name = request.Ib_customer_contact_last_name,
                       Ib_customer_contact_mobile = request.Ib_customer_contact_mobile,
                       Ib_customer_contact_note=request.Ib_customer_contact_note,
                       Ib_customer_contact_office_fax = request.Ib_customer_contact_office_fax,
                       Ib_customer_contact_office_phone = request.Ib_customer_contact_office_phone

                   }
               }

            };
            db.Ib_customers.Add(cus);
            return await db.SaveChangesAsync();
        }



        public async Task<int> Delete(int customerId)
        {
            var customer = await db.Ib_customers.FindAsync(customerId);
            if (customer == null)
            {
                throw new LinxOneException($"Cannot find a customer :{customerId}");
            }
            db.Ib_customers.RemoveRange(customer);
            return await db.SaveChangesAsync();
        }

        public async Task<List<CustomerViewRequest>> GetAll()
        {
            var query = from c in db.Ib_customers select new { c };
            var data = await query.Select(x => new CustomerViewRequest()
            {
                id = x.c.Ib_record_primary_key,
                name = x.c.Ib_customer_name,
                registration = x.c.Ib_customer_registration,
                cus_type = x.c.Ib_customer_type
            }).ToListAsync();
            return data;
        }

        public Task<PageViewModel<CustomerViewRequest>> GetAllPaging(GetCustomerPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<List<AddressViewRequest>> GetCustomerAddressByCustomerId(int id)
        {

            var query = from c in db.Ib_customers
                        join a in db.Ib_addresses
                        on c.Ib_record_primary_key equals a.Ib_customer_id
                        where c.Ib_record_primary_key == id
                        select new { c, a };




            var data = await query.Select(x => new AddressViewRequest()
            {

                Ib_customer_address_city = x.a.Ib_customer_address_city,
                Ib_customer_address_line_1 = x.a.Ib_customer_address_line_1,
                Ib_customer_address_line_2 = x.a.Ib_customer_address_line_2,
                Ib_customer_address_phone_1 = x.a.Ib_customer_address_phone_1,
                Ib_customer_address_phone_2 = x.a.Ib_customer_address_phone_2,
                Ib_customer_address_postal_code = x.a.Ib_customer_address_postal_code,
                Ib_customer_address_state = x.a.Ib_customer_address_state,
                Ib_customer_address_website_url = x.a.Ib_customer_address_website_url,
                Ib_customer_id = x.a.Ib_customer_id
                // id =x.c.Ib_record_primary_key,
                // name=x.c.Ib_customer_name,
                // registration=x.c.Ib_customer_registration,
                //cus_type=x.c.Ib_customer_type
            }).ToListAsync();
            return data;
        }

        public async Task<List<ContactViewRequest>> GetCustomerContactByCustomerId(int id)
        {
            var query = from c in db.Ib_customers
                        join cc in db.Ib_customer_contacts
                        on c.Ib_record_primary_key equals cc.Ib_customer_id
                        where c.Ib_record_primary_key == id
                        select new { c, cc };

            var data = await query.Select(x => new ContactViewRequest()
            {
                Ib_customer_contact_email_1 = x.cc.Ib_customer_contact_email_1,
                Ib_customer_contact_email_2 = x.cc.Ib_customer_contact_email_2,
                Ib_customer_contact_first_name = x.cc.Ib_customer_contact_first_name,
                Ib_customer_contact_last_name = x.cc.Ib_customer_contact_last_name,
                Ib_customer_contact_mobile = x.cc.Ib_customer_contact_mobile,
                Ib_customer_contact_note = x.cc.Ib_customer_contact_note,
                Ib_customer_contact_office_fax = x.cc.Ib_customer_contact_office_fax,
                Ib_customer_contact_office_phone = x.cc.Ib_customer_contact_office_phone,
                Ib_record_primary_key = x.cc.Ib_record_primary_key

            }).ToListAsync();
            return data;
        }

        public async Task<List<InvoiceViewRequest>> GetCustomerInvoiceCustomerId(int id)
        {
            var query = from c in db.Ib_customers
                        join i in db.Ib_invoices
                        on c.Ib_record_primary_key equals i.Ib_invoice_customer_id
                        where c.Ib_record_primary_key == id
                        select new { c, i };

            var data = await query.Select(x => new InvoiceViewRequest()
            {
                Ib_invoice_customer_id = x.i.Ib_invoice_customer_id,
                Ib_invoice_date = x.i.Ib_invoice_date,
                Ib_invoice_due_date = x.i.Ib_invoice_due_date,
                Ib_invoice_encode = x.i.Ib_invoice_encode,
                Ib_invoice_no = x.i.Ib_invoice_no,
                Ib_invoice_note = x.i.Ib_invoice_note,
                Ib_invoice_subject = x.i.Ib_invoice_subject,
                Ib_invoice_subtotal = x.i.Ib_invoice_subtotal,
                Ib_invoice_total_after_discounts = x.i.Ib_invoice_total_after_discounts,
                Ib_invoice_total_after_taxes = x.i.Ib_invoice_total_after_taxes,
                Ib_invoice_total_outstanding = x.i.Ib_invoice_total_outstanding,
                Ib_invoice_total_paid = x.i.Ib_invoice_total_paid,
                Ib_record_primary_key = x.i.Ib_record_primary_key,



            }).ToListAsync();
            return data;
        }

        public Task<int> Update(CustomerUpdateRequest request)
        {
            throw new NotImplementedException();
        }

    }
}
