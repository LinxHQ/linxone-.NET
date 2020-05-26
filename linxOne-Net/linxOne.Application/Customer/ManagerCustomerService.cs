using linxOne.Data.EF;
using linxOne.Data.Entities;
using linxOne.ViewModel.Common;
using linxOne.ViewModels.Customer.DataTransferObject;
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


               Ib_customer_name=request.Ib_customer_name,
               Ib_customer_registration=request.Ib_customer_registration,
               Ib_customer_type=request.Ib_customer_type




            };
            db.Ib_customers.Add(cus);
            return await db.SaveChangesAsync();
        }

        public Task<int> Delete(int addressId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CustomerViewRequest>> GetAll()
        {
            var query = from c in db.Ib_customers select new { c };
            var data = await query.Select(x => new CustomerViewRequest()
            {
                id =x.c.Ib_record_primary_key,
                name=x.c.Ib_customer_name,
                registration=x.c.Ib_customer_registration,
               cus_type=x.c.Ib_customer_type
            }).ToListAsync();
            return  data;
        }

        public Task<PageViewModel<CustomerViewRequest>> GetAllPaging(GetCustomerPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(CustomerUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
