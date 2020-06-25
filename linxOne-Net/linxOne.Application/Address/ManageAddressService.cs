using linxOne.Data.EF;
using linxOne.Data.Entities;
using linxOne.Utility.Exceptions;
using linxOne.ViewModel.Address.DataTransferObject;
using linxOne.ViewModel.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace linxOne.Application.Address
{
    public class ManageAddressService : IAddressService
    {
        private readonly linxOneDbContext db;
        public ManageAddressService(linxOneDbContext context)
        {
            db = context;
        }
        public async Task<int> Create(AddressCreateRequest request)
        {
            var adderss = new Ib_address()
            {


                Ib_customer_address_city = request.Ib_customer_address_city,
                Ib_customer_address_line_1 = request.Ib_customer_address_line_1,
                Ib_customer_address_line_2 = request.Ib_customer_address_line_2,
                Ib_customer_address_phone_1 = request.Ib_customer_address_phone_1,
                Ib_customer_address_phone_2 = request.Ib_customer_address_phone_2,
                Ib_customer_address_postal_code = request.Ib_customer_address_postal_code,
                Ib_customer_address_state = request.Ib_customer_address_state,
                Ib_customer_address_website_url = request.Ib_customer_address_website_url,
                Ib_customer_id = request.Ib_customer_id,




            };
            db.Ib_addresses.Add(adderss);
            return await db.SaveChangesAsync();

        }

        public async Task<int> Delete(int addressId)
        {

            var address = await db.Ib_addresses.FindAsync(addressId);
            if (address == null) throw new LinxOneException($"Cannot find an address with id{addressId}");
            {

            }
            db.Ib_addresses.Remove(address);
            return await db.SaveChangesAsync();

        }



        public async Task<PageViewModel<AddressViewRequest>> GetAllPaging(GetAddressPagingRequest request)
        {
            var query = from a in db.Ib_addresses
                        where a.Ib_customer_address_line_1.Contains(request.keyword)
                        select a;
            if (request.keyword != string.Empty)
            {
                query = query.Where(a => a.Ib_customer_address_line_1.Contains(request.keyword));
            }

            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.pageIndex - 1) * request.pageSize)
                .Take(request.pageSize)
                .Select(a => new AddressViewRequest()
                {
                    Ib_customer_address_city = a.Ib_customer_address_city,
                    Ib_customer_address_line_1 = a.Ib_customer_address_line_1,
                    Ib_customer_address_line_2 = a.Ib_customer_address_line_2,
                    Ib_customer_address_phone_1 = a.Ib_customer_address_phone_1,
                    Ib_customer_address_phone_2 = a.Ib_customer_address_phone_2,
                    Ib_customer_address_postal_code = a.Ib_customer_address_postal_code,


                }).ToListAsync();

            var pageViewModel = new PageViewModel<AddressViewRequest>()
            {

                TotalRecords = totalRow,
                Items = data

            };
            return pageViewModel;
        }

        public async Task<int> Update(AddressUpdateRequest request)
        {
            var a = await db.Ib_addresses.FindAsync(request.Ib_record_primary_key);
            if (a == null) throw new LinxOneException($"Cannot find an address with id{request.Ib_record_primary_key}");

            var adderss = new Ib_address()
            {

                Ib_record_primary_key = request.Ib_record_primary_key,
                Ib_customer_address_city = request.Ib_customer_address_city,
                Ib_customer_address_line_1 = request.Ib_customer_address_line_1,
                Ib_customer_address_line_2 = request.Ib_customer_address_line_2,
                Ib_customer_address_phone_1 = request.Ib_customer_address_phone_1,
                Ib_customer_address_phone_2 = request.Ib_customer_address_phone_2,
                Ib_customer_address_postal_code = request.Ib_customer_address_postal_code,
                Ib_customer_address_state = request.Ib_customer_address_state,
                Ib_customer_address_website_url = request.Ib_customer_address_website_url,
                Ib_customer_id = request.Ib_customer_id,




            };
            db.Ib_addresses.Update(adderss);
            return await db.SaveChangesAsync();

        }
    }
}
